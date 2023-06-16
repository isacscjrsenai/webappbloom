
using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.ViewModels;
using WebAppBloom.Contexts;
namespace WebAppBloom.Controllers;
public class CompetenciaController:Controller{
    
    private readonly AppDbContext _context;

   public CompetenciaController(AppDbContext context){
        _context = context;
   } 
   public IActionResult Index(){

         var listaCompe = _context.Competencias.ToList();
            var listaViewModel = new ListaCompetenciaViewModel{

                  Competencias = listaCompe
            };
         return View(listaViewModel);
   }

   public IActionResult RelatorioCompe(){
      
      /*var competencia = new Competencia(){
           ColunaBloom = "Teste Coluna",
           LinhaBloom = "Teste Linha"
      };
      
      var viewModel = new DetalhesCompViewModel(){
            Competencia = competencia,
            TituloPagina = "Página de Teste"
      };*/
      var competencias = _context.Competencias.ToList();
      return View();




   }
      public IActionResult Listar(){
            var listaCompe = _context.Competencias.ToList();
            var listaViewModel = new ListaCompetenciaViewModel{

                  Competencias = listaCompe
            };
            return View(listaViewModel);
      }

       [HttpPost]
       public IActionResult Index(CriarCompetenciaViewModel dados){
            var competencia = new Competencia(dados.ColunaBloom, dados.LinhaBloom);
            _context.Add(competencia);
            _context.SaveChanges();
            return  RedirectToAction(nameof(Index));
       }
}