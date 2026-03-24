// Desarrollado por: [Tu Nombre]

namespace Portafolioo.Models
{
    public class ExperienciaLaboral
    {
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public string Descripcion { get; set; }
        public int AnoInicio { get; set; }
        public int? AnoFin { get; set; } // null = trabajo actual
        public string IconoUrl { get; set; }

        // Constructor
        public ExperienciaLaboral(string empresa, string cargo, string descripcion, int anoInicio, int? anoFin, string iconoUrl)
        {
            Empresa = empresa;
            Cargo = cargo;
            Descripcion = descripcion;
            AnoInicio = anoInicio;
            AnoFin = anoFin;
            IconoUrl = iconoUrl;
        }
    }
}