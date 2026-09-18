using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaControleMateriais_flp.Data;
using SistemaControleMateriais_flp.Models;

namespace SistemaControleMateriais_flp.Controllers;

public class HomeController : Controller
{
    private readonly BancoDados banco;

    public HomeController(BancoDados banco)
    {
        this.banco = banco;
    }

    public IActionResult Index()
    {
        List<Material> materiais = banco.ListarMateriais();
        DashboardViewModel dashboard = new DashboardViewModel
        {
            TotalMateriais = materiais.Count
        };

        foreach (Material material in materiais)
        {
            dashboard.TotalUnidades += material.Quantidade;

            if (material.Quantidade == 0)
            {
                dashboard.EstoqueZerado++;
            }
            else if (material.Quantidade <= material.EstoqueMinimo)
            {
                dashboard.EstoqueBaixo++;
            }
        }

        return View(dashboard);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
