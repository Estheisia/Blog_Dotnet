using Blog_Barneaud_Huyghe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Barneaud_Huyghe.Controllers
{
    public class AdministrateurController : Controller
    {

        private readonly ArticleDbContext _db;

        public AdministrateurController(ArticleDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var liste = from m in _db.Article select m;
            liste = liste.Include(l => l.ArticleIndividuId);
            return View(liste.ToList());
        }

        public IActionResult Commentaires()
        {
            var liste = from m in _db.Commentaire select m;
            return View(liste.ToList());
        }
        public IActionResult Blogueurs()
        {
            var liste = from m in _db.Individu select m;
            return View(liste.ToList());
        }
        public IActionResult Articles()
        {
            var liste = from m in _db.Article select m;
            liste = liste.Include(l => l.ArticleIndividuId);
            return View(liste.ToList());
        }

        public async Task<IActionResult> DeleteComment(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var commentaire = await _db.Commentaire
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commentaire == null)
            {
                return NotFound();
            }

            return View(commentaire);
        }

        public async Task<IActionResult> ReverseAutorisation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var individu = await _db.Individu
                .FirstOrDefaultAsync(m => m.IndividuId == id);
            if (individu == null)
            {
                return NotFound();
            }

            return View(individu);
        }
        public async Task<IActionResult> DeleteCommentConfirmed(int? id)
        {
          
            
            var commentaire = await _db.Commentaire
                .FirstOrDefaultAsync(m => m.Id == id);
            _db.Commentaire.Remove(commentaire);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> ReverseAutorisationConfirmed(int? id)
        {

            var individu = await _db.Individu.FindAsync(id);

            
            _db.Update(individu);


            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



    }

}

       


