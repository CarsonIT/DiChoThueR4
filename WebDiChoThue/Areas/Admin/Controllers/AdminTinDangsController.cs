﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebDiChoThue.Helpper;
using WebDiChoThue.Models;

namespace WebDiChoThue.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTinDangsController : Controller
    {
        private readonly dbMarketsContext _context;

        public INotyfService _notifyService { get; }
        public AdminTinDangsController(dbMarketsContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

        // GET: Admin/AdminTinDangs
        public IActionResult Index(int? page)
        {
            //Tạo 20 bài để test
            //var tin = _context.TinDangs.Find(137);
            //for (int i = 1; i < 20; i++)
            //{
            //    TinDang tinDang = new TinDang();
            //    tinDang.Title = tin.Title;
            //    tinDang.Published = tin.Published;
            //    tinDang.Alias = tin.Alias;
            //    tinDang.IsHot = tin.IsHot;
            //    tinDang.IsNewfeed = tin.IsNewfeed;
            //    tinDang.CreatedDate = tin.CreatedDate;
            //    tinDang.Contents = tin.Contents;
            //    tinDang.MetaDesc = tin.Title;
            //    tinDang.MetaKey = tin.Title;
            //    _context.Add(tinDang);
            //    _context.SaveChanges();
            //}



            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsTinDangs = _context.TinDangs
                 .AsNoTracking()
                 .OrderByDescending(x => x.PostId);
            PagedList<TinDang> models = new PagedList<TinDang>(lsTinDangs, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }


        // GET: Admin/AdminTinDangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinDang = await _context.TinDangs
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tinDang == null)
            {
                return NotFound();
            }

            return View(tinDang);
        }

        // GET: Admin/AdminTinDangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminTinDangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TinDang tinDang, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                //Xử lý thumb
                if (fThumb != null)
                {

                    string extension = Path.GetExtension(fThumb.FileName);
                    string imageName = Utilities.SEOUrl(tinDang.Title) + extension;
                    tinDang.Thumb = await Utilities.UploadFile(fThumb, @"news", imageName.ToLower());
                }
                if (string.IsNullOrEmpty(tinDang.Thumb)) tinDang.Thumb = "default.jpg";
                tinDang.Alias = Utilities.SEOUrl(tinDang.Title);
                tinDang.CreatedDate = DateTime.Now;

                _context.Add(tinDang);
                await _context.SaveChangesAsync();
                _notifyService.Success("Thêm tin thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(tinDang);
        }

        // GET: Admin/AdminTinDangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinDang = await _context.TinDangs.FindAsync(id);
            if (tinDang == null)
            {
                return NotFound();
            }
            return View(tinDang);
        }

        // POST: Admin/AdminTinDangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TinDang tinDang, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != tinDang.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (fThumb != null)
                    {

                        string extension = Path.GetExtension(fThumb.FileName);
                        string imageName = Utilities.SEOUrl(tinDang.Title) + extension;
                        tinDang.Thumb = await Utilities.UploadFile(fThumb, @"news", imageName.ToLower());
                    }
                    if (string.IsNullOrEmpty(tinDang.Thumb)) tinDang.Thumb = "default.jpg";


                    _context.Update(tinDang);
                    await _context.SaveChangesAsync();
                    _notifyService.Success("Cập nhật thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinDangExists(tinDang.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tinDang);
        }

        // GET: Admin/AdminTinDangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinDang = await _context.TinDangs
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tinDang == null)
            {
                return NotFound();
            }

            return View(tinDang);
        }

        // POST: Admin/AdminTinDangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinDang = await _context.TinDangs.FindAsync(id);
            _context.TinDangs.Remove(tinDang);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool TinDangExists(int id)
        {
            return _context.TinDangs.Any(e => e.PostId == id);
        }
    }
}
