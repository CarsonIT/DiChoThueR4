using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDiChoThue.Extension;
using WebDiChoThue.Models;
using WebDiChoThue.ModelViews;

namespace WebDiChoThue.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly dbMarketsContext _context;

        public INotyfService _notifyService { get; }
        public ShoppingCartController(dbMarketsContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }


        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }


        // 1. Thêm mới sản phẩm vào giỏ hàng
        //2. Cập nhật lại số lượng sản phẩm trong giỏ hàng
        //3. Xóa sản phẩm khỏi giỏ hàng
        //4. Xóa luôn giỏ hàng

        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount)
        {
            List<CartItem> cart = GioHang;

            try
            {
                //Thêm sản phẩm vào giỏ hàng
                CartItem item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null)//đã có --> cập nhật số lượng
                {

                    item.amount = item.amount + amount.Value;
                    //Lưu lại session
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                else
                {
                    Product hh = _context.Products.SingleOrDefault(p => p.ProductId == productID);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = hh
                    };
                    cart.Add(item); // Thêm vào giỏ 
                }

                //lưu lại session
                HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                _notifyService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });

            }
            catch
            {
                return Json(new { success = false });
            }
        }


        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int? amount)
        {
            //Lấy giỏ hàng ra để dxuwr lý
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            try
            {
                if (cart != null)
                {
                    CartItem item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                    if (item != null && amount.HasValue)//đã có --> cập nhật số lượng
                    {
                        item.amount = amount.Value;
                    }

                    //lưu lại session
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }


        [HttpPost]
        [Route("api/cart/remove")]
        public IActionResult Remove(int productID)
        {


            try
            {
                List<CartItem> gioHang = GioHang;
                CartItem item = gioHang.SingleOrDefault(p => p.product.ProductId == productID);


                if (item != null)
                {
                    gioHang.Remove(item);
                }
                //lưu lại session
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [Route("cart.html", Name = "Cart")]
        public IActionResult Index()
        {
            return View(GioHang);
        }
    }
}
