using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NADD.Models;

namespace NADD.Controllers
{
    public class Questoes1Controller : Controller
    {
        private readonly Contexto _context;

        public Questoes1Controller(Contexto context)
        {
            _context = context;
        }
        
        // GET: Questoes1
        public async Task<IActionResult> Index()
        {
            /*var contexto = _context.Questoes.Include(a => a.Avaliacao);
            return View(await contexto.ToListAsync());*/

            var contexto = _context.Avaliacao.Include(a => a.Disciplinas).Include(a => a.Professor).Include(q => q.Questoes);
            return View(await contexto.ToListAsync());
        }

        // GET: Questoes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questoes = await _context.Questoes
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.QuestoesId == id);
            if (questoes == null)
            {
                return NotFound();
            }

            return View(questoes);
        }

        // GET: Questoes1/Create
        public IActionResult Create()
        {
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Periodo");
            return View();
        }

        // POST: Questoes1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestoesId,NumeroQuestao,Valor,Tipo,Observacao,AvaliacaoId")] Questoes questoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questoes);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return Redirect("/Questoes1/ListaQuestoes/" + questoes.AvaliacaoId);
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Periodo", questoes.AvaliacaoId);
            return View(questoes);
        }

        // GET: Questoes1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questoes = await _context.Questoes.FindAsync(id);
            if (questoes == null)
            {
                return NotFound();
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Periodo", questoes.AvaliacaoId);
            return View(questoes);
        }

        // POST: Questoes1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestoesId,NumeroQuestao,Valor,Tipo,Observacao,AvaliacaoId")] Questoes questoes)
        {
            if (id != questoes.QuestoesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestoesExists(questoes.QuestoesId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                return Redirect("/Questoes1/ListaQuestoes/" + questoes.AvaliacaoId);
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Periodo", questoes.AvaliacaoId);
            return View(questoes);
        }

        // GET: Questoes1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questoes = await _context.Questoes
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.QuestoesId == id);
            if (questoes == null)
            {
                return NotFound();
            }

            return View(questoes);
        }

        // POST: Questoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questoes = await _context.Questoes.FindAsync(id);
            _context.Questoes.Remove(questoes);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return Redirect("/Questoes1/ListaQuestoes/" + questoes.AvaliacaoId);
        }

        private bool QuestoesExists(int id)
        {
            return _context.Questoes.Any(e => e.QuestoesId == id);
        }

        //-----------------------------------------//
        //Rotas Custom
        
        // GET: Questoes1/Verifica/5
        public async Task<IActionResult> Verifica(long? id)
        {
            if (id != null)
            {
                var questoes = _context.Questoes.Where(a => a.AvaliacaoId == id).FirstOrDefault();
                //ViewData["Periodo"] = questoes.Avaliacao;
                //ViewData["NomeProf"] = questoes.Avaliacao.Professor.NomeProfessor;

                if (questoes == null)
                {
                    return RedirectToAction(nameof(Create));
                }
                else
                {
                    //return RedirectToAction(nameof(ListQeustoes));
                    return Redirect("/Questoes1/ListaQuestoes/" + id);
                    /*var questoes2 = _context.Questoes.Where(a => a.AvaliacaoId == id).ToList();
                    //Periodo da Prova
                    
                    ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Periodo", questoes.AvaliacaoId);
                    return View(questoes2);
                    */
                }
            }
            else
            {
                return View(id);
            }
        }
        [ActionName("listaQuestoes")]
        // GET: Questoes1/listaQuestoes/5
        public async Task<IActionResult> listaQuestoes(long? id)
        {
            /*var contexto = _context.Questoes.Include(a => a.Avaliacao);
            return View(await contexto.ToListAsync());*/
            var questoes = _context.Questoes.Where(a => a.AvaliacaoId == id).ToList();

            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Periodo");
            
            return View(questoes);
        }
        
        //-----------------------------------------//
    }
}
