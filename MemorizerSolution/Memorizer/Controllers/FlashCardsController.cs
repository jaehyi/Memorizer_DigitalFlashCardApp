using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Memorizer.Models;
using Microsoft.AspNetCore.Identity;
using Memorizer.Models.ViewModel;

namespace Memorizer.Controllers
{
    public class FlashCardsController : Controller
    {
        private readonly MemorizerDbContext _context;
        //private readonly UserManager<BugTrackerUser> _userManager;

        //public TasksController(UserManager<BugTrackerUser> userManager, BTAuthContext context)
        //{
        //    _userManager = userManager;
        //    _context = context;
        //}

        public FlashCardsController(MemorizerDbContext context)
        {
            _context = context;
        }

        // GET: FlashCards
        public async Task<IActionResult> Index()
        {
            // return View(await _context.FlashCards.ToListAsync());

            return View(await _context.FlashCards.Include(f => f.Category).ToListAsync());


            // var catRes = await _context.Categories.ToListAsync();
            // var flashRes = await _context.FlashCards.ToListAsync();
            //var filteredTask = catRes.Join(flashRes,
            //          c => c.Id,
            //          f => f.Category.Id,
            //          (c, f) => f).ToList();

            //var cardCat = await _context.FlashCards.Include(f => f.Category)
            //    .ThenInclude(c => c).ToListAsync();



            //// var tuple = (catRes, flashRes);
            // return View(cardCat);
        }

        // GET: FlashCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flashCard = await _context.FlashCards
                .Include(f => f.Category)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flashCard == null)
            {
                return NotFound();
            }

            return View(flashCard);
        }

        // GET: FlashCards/Create
        public IActionResult Create()
        {
            ViewData["CategoryDropDownList"] = _context.Categories
                .AsNoTracking().ToList();
            return View();

            //FlashCardCategoryViewModel flashCardCategoryViewModel = new FlashCardCategoryViewModel();
            //flashCardCategoryViewModel.Categories = _context.Categories.AsNoTracking().ToList();
            //return View(flashCardCategoryViewModel);
        }

        // POST: FlashCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Question,Answer,CreatedOn,UpdatedOn,Note")] FlashCard flashCard, int CategoryId)
        {
            if (ModelState.IsValid )
            {
                flashCard.CategoryId = CategoryId;
                _context.Add(flashCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flashCard);
        }

        // GET: FlashCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flashCard = await _context.FlashCards.FindAsync(id);
            if (flashCard == null)
            {
                return NotFound();
            }
            
            ViewData["CategoryDropDownList"] = _context.Categories
                .AsNoTracking().ToList();

            return View(flashCard);
        }

        // POST: FlashCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Question,Answer,CreatedOn,UpdatedOn,Note")] FlashCard flashCard, int CategoryId)
        {
            if (id != flashCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    flashCard.CategoryId = CategoryId;
                    _context.Update(flashCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlashCardExists(flashCard.Id))
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
            return View(flashCard);
        }

        // GET: FlashCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flashCard = await _context.FlashCards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flashCard == null)
            {
                return NotFound();
            }

            return View(flashCard);
        }

        // POST: FlashCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flashCard = await _context.FlashCards.FindAsync(id);
            _context.FlashCards.Remove(flashCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlashCardExists(int id)
        {
            return _context.FlashCards.Any(e => e.Id == id);
        }
    }
}
