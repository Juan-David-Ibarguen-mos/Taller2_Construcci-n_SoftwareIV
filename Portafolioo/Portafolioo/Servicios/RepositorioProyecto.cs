using Portafolioo.Models;

namespace Portafolioo.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/amazon.png",
                    Tecnologias = "ASP.NET Core, SQL Server, Bootstrap",
                    Estado = "Completado",
                    AnoDesarrollo = 2023,
                    EsDestacado = true
                },
                new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/imagenes/nyt.png",
                    Tecnologias = "React, Node.js, CSS",
                    Estado = "En desarrollo",
                    AnoDesarrollo = 2024,
                    EsDestacado = false
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social de comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/reddit.png",
                    Tecnologias = "React, Firebase, Material UI",
                    Estado = "Completado",
                    AnoDesarrollo = 2023,
                    EsDestacado = true
                },
                new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda de videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/imagenes/steam.png",
                    Tecnologias = "ASP.NET Core, SQL Server, Bootstrap",
                    Estado = "En desarrollo",
                    AnoDesarrollo = 2024,
                    EsDestacado = false
                }
            };
        }
    }
}