using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NADD.Models;
using Rotativa.AspNetCore;

namespace NADD.Controllers
{
    public class AvaliacaosController : Controller
    {
        private readonly Contexto _context;

        public AvaliacaosController(Contexto context)
        {
            _context = context;
        }

        // GET: Avaliacaos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Avaliacao.Include(a => a.Disciplinas).Include(a => a.Professor);
            return View(await contexto.ToListAsync());
        }

        // GET: Avaliacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacao
                .Include(a => a.Disciplinas)
                .Include(a => a.Professor)
                .FirstOrDefaultAsync(m => m.AvaliacaoId == id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina");
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "NomeProfessor");
            return View(avaliacao);
        }

        // GET: Avaliacaos/Create
        public IActionResult Create()
        {
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina");
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "NomeProfessor");
            return View();
        }

        // POST: Avaliacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvaliacaoId,DtAplicacao,DtCriacao,QtyQuestoes,ValorQuestExp,ValorProvaExp,RefBibliograficas,Eqdistvquest,PQuestMultdisc,Ppquestcontext,Observacao,Periodo,DisciplinaId,ProfessorId,TotValor,Media")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avaliacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);
            return View(avaliacao);
        }

        // GET: Avaliacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacao.FindAsync(id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);
            return View(avaliacao);
        }

        // POST: Avaliacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvaliacaoId,DisciplinaId,ProfessorId,Periodo,Observacao")] Avaliacao avaliacao)
        {
            if (id != avaliacao.AvaliacaoId)
            {
                
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avaliacao);
                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvaliacaoExists(avaliacao.AvaliacaoId))
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
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);
            return View(avaliacao);
        }

        // GET: Avaliacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacao
                .Include(a => a.Disciplinas)
                .Include(a => a.Professor)
                .FirstOrDefaultAsync(m => m.AvaliacaoId == id);
            if (avaliacao == null)
            {
                return NotFound();
            }

            return View(avaliacao);
        }

        // POST: Avaliacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avaliacao = await _context.Avaliacao.FindAsync(id);
            _context.Avaliacao.Remove(avaliacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvaliacaoExists(int id)
        {
            return _context.Avaliacao.Any(e => e.AvaliacaoId == id);
        }
        // GET: Avaliacaos/finalizarProva/5
        public async Task<IActionResult> finalizarProva(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacao.FindAsync(id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            var amem = new SelectList(_context.Questoes.Where(a => a.AvaliacaoId == id).Select(a => a.AvaliacaoId).ToList());
            var soma = new SelectList(_context.Questoes.Where(a => a.AvaliacaoId == id).Select(a => a.Valor).ToList());
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);
            ViewData["qtd_questoes"] = amem.Count();
            //var contandoIsso = 0 ;
            //foreach (var somando in soma)
            //{
            //    Console.WriteLine(somando);
            //}
            //ViewData["soma_questoes"] = contandoIsso;
            return View(avaliacao);
        }
        [ActionName("finalizarProva")]
        // POST: Avaliacaos/finalizarProva/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> finalizarProva(int id, [Bind("AvaliacaoId,DisciplinaId,ProfessorId,Periodo,ValorQuestExp,ValorProvaExp,RefBibliograficas,Eqdistvquest,PQuestMultdisc,Ppquestcontext,QtyQuestoes")] Avaliacao avaliacao)
        {
            /*if (id != avaliacao.AvaliacaoId)
            {
                return await NotFound();
            }
            if (ModelState.IsValid)
            {*/
                try
                {
                    _context.Update(avaliacao);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvaliacaoExists(avaliacao.AvaliacaoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            //}
            //ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            //ViewData["ProfessorId"] = new SelectList(_context.Professor, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);
            //return View(avaliacao);
        }

        // POST: Avaliacaos/AvaliacaoPDF/5
        [ActionName("AvaliacaoPDF")]
        public IActionResult VisualizarAvaliacoesPDF(long? id)
        {
            var contexto = _context.Avaliacao.Include(a => a.Disciplinas).Include(a => a.Professor);
            return new ViewAsPdf("AvaliacaoPDF", contexto.ToList()) { FileName = "relatorio.pdf" };
        }

        // POST: Avaliacaos/QuestoesPDF/5
        [ActionName("QuestoesPDF")]
        public IActionResult VisualizarQuestoesPDF(long? id)
        {
            var contexto = _context.Questoes.Where(a => a.AvaliacaoId == id);
            return new ViewAsPdf("QuestoesPDF", contexto.ToList()) { FileName = "relatorio.pdf" };
        }

    }
}
