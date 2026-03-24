using Microsoft.AspNetCore.Mvc;
using Portafolioo.Models;
using Portafolioo.Servicios;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly RepositorioProyectos repositorio = new RepositorioProyectos();

    public IActionResult Index()
    {
        var proyectos = repositorio.ObtenerProyectos().Take(3).ToList();

        var experiencias = new List<ExperienciaLaboral>
        {
            new ExperienciaLaboral(
                "Tech Solutions",
                "Desarrollador Junior",
                "Desarrollo de aplicaciones web con ASP.NET y mantenimiento de sistemas.",
                2019,
                2021,
                "https://cdn-icons-png.flaticon.com/512/5968/5968267.png"
            ),
            new ExperienciaLaboral(
                "Innovatech",
                "Desarrollador Full Stack",
                "Construcción de APIs REST y desarrollo de interfaces con React.",
                2021,
                2023,
                "https://cdn-icons-png.flaticon.com/512/5968/5968292.png"
            ),
            new ExperienciaLaboral(
                "DevCompany",
                "Ingeniero de Software",
                "Diseño de arquitectura y liderazgo técnico en proyectos.",
                2023,
                null,
                "https://cdn-icons-png.flaticon.com/512/2721/2721297.png"
            )
        };

        var modelo = new HomeIndexViewModel
        {
            Proyectos = proyectos,
            Experiencias = experiencias
        };

        return View(modelo);
    }

    public IActionResult Proyectos()
    {
        var proyectos = repositorio.ObtenerProyectos();
        return View(proyectos);
    }

    [HttpGet]
    public IActionResult Contacto() => View();

    [HttpPost]
    public IActionResult Contacto(ContactoViewModel vm)
    {
        return RedirectToAction("Gracias");
    }

    public IActionResult Gracias() => View();

    // ── NUEVA ACCIÓN: Detail ──
    public IActionResult Detail(int id)
    {
        // Buscar el proyecto por Id
        var proyecto = repositorio.ObtenerProyectos().FirstOrDefault(p => p.Id == id);

        // Si no se encuentra, retornar 404
        if (proyecto == null)
        {
            return NotFound();
        }

        // Retornar la vista Detail.cshtml con el proyecto como modelo
        return View(proyecto);
    }
}