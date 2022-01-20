using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDiChoThue.Extension;
using WebDiChoThue.Helpper;
using WebDiChoThue.Models;
using WebDiChoThue.ModelViews;

namespace WebDiChoThue.Controllers
{

    public class CheckoutController : Controller
    {
        private readonly dbMarketsContext _context;

        public INotyfService _notifyService { get; }
        public CheckoutController(dbMarketsContext context, INotyfService notifyService)
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


        //Get: Checkout/Index
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");

            MuaHangVM model = new MuaHangVM();

            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;
            }

            ViewBag.GioHang = cart;
            return View(model);
        }



        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(MuaHangVM muaHang)
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CustomerId");

            MuaHangVM model = new MuaHangVM();

            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                model.CustomerId = khachhang.CustomerId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

                khachhang.Address = muaHang.Address;

                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    Order donhang = new Order();
                    donhang.CustomerId = model.CustomerId;
                    donhang.Address = model.Address;

                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 1;
                    donhang.Deleted = false;
                    donhang.Paid = false;
                    donhang.Note = Utilities.StripHTML(model.Note);
                    donhang.TotalMoney = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    _context.Add(donhang);
                    _context.SaveChanges();

                    // Tạo danh sách đơn hàng

                    foreach(var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = donhang.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Amount = item.amount;
                        orderDetail.TotalMoney = donhang.TotalMoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        _context.Add(orderDetail);
                    }
                    _context.SaveChanges();
                    // Clear giỏ hàng
                    HttpContext.Session.Remove("GioHang");
                    // Xuất thông báo
                    _notifyService.Success("Đơn hàng đặt thành công");
                    // Cập nhật thông tin khách hàng
                    return RedirectToAction("Success");
                }    
            }
            catch(Exception ex)
            {
                ViewBag.GioHang = cart;
                return View(model);
            }
            ViewBag.GioHang = cart;
            return View(model);
        }

//        [Route("dat-hang-thanh-cong.html", Name = "Success")]
//        public IActionResult Success()
//        {
//            try
//            {
//                var taikhoanID = HttpContext.Session.GetString("CustomerId");
//                if(string.IsNullOrEmpty(taikhoanID))
//                {
//                    return RedirectToAction("Login", "Accounts", new { returnUrl = "/dat-hang-thanh-cong.html" });

//                }


//                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
//                var donhang = _context.Orders.Where(x => x.CustomerId == Convert.ToInt32(taikhoanID));

//                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
//                successVM.FullName = khachhang.FullName;
//+
//                successVM.Phone = khachhang.Phone;

//                successVM.Address = khachhang.Address;
                
//            }
//        }
    }
}
