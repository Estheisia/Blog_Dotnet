using Blog_Barneaud_Huyghe.Data;
using Blog_Barneaud_Huyghe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Barneaud_Huyghe.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleDbContext _db;

        public ArticleController(ArticleDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //IEnumerable<Article> objList = _db.Article;//(from m in _db.Article select m).Distinct().ToList();
            var liste = from m in _db.Article select m;
            liste = liste.Include(l => l.ArticleIndividuId);
            return View(liste.ToList());
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Article obj)
        {
            if (ModelState.IsValid)
            {
                _db.Article.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DETAILS
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Article.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DETAILS
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(Article obj)
        {
            if (ModelState.IsValid)
            {
                _db.Article.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Article.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Article.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Article.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
