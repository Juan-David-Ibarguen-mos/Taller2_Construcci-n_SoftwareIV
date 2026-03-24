using Portafolioo.Models;

namespace Portafolioo.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Proyecto> Proyectos { get; set; }

        public IEnumerable<ExperienciaLaboral> Experiencias { get; set; }
    }
}