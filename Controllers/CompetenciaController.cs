using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
namespace WebAppBloom.Controllers
{
public class CompetenciaController : Controller{
    public IActionResult Index(){
        Competencia competencia = new Competencia();
        competencia.ColunaBloom = "Memorizar";
        competencia.LinhaBloom = "Compreender";
        ViewData["titulo"] = "Compreender o funcionamento do ...";
        ViewData["tablebloom"] = competencia;
        return View();
    }
}
}
