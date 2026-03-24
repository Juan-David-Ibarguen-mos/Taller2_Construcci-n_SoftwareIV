namespace Portafolioo.Models
{
    public class Proyecto
    {
        public int Id { get; set; }                // Nuevo: identificador único
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenURL { get; set; }
        public string Link { get; set; }
        public string Tecnologias { get; set; }      // Ej: "ASP.NET Core, SQL Server, Bootstrap"
        public string Estado { get; set; }           // Ej: "Completado", "En desarrollo"
        public int AnoDesarrollo { get; set; }       // Ej: 2024
        public bool EsDestacado { get; set; }        // true = aparece con badge especial
    }
}