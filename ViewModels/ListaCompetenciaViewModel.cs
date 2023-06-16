using WebAppBloom.Models;
public class ListaCompetenciaViewModel
{
    /* Listar */
    public ICollection<Competencia> Competencias {get;set;} = new List<Competencia>();
    
}