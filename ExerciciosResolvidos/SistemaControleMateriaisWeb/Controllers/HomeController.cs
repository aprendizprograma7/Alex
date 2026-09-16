using System.Diagnostics;
using SistemaControleMateriaisWeb.Data;
using Microsoft.AspNetCore.Mvc;
using SistemaControleMateriaisWeb.Models;

namespace SistemaControleMateriaisWeb.Controllers;

public class HomeController : Controller
{
    private readonly BancoDados Banco;

    public HomeController(BancoDados banco)
    {
        Banco = banco;
    }

    public IActionResult Index()
    {
        List<Material> materiais = Banco.ListarMateriais();

        DashboardViewModel dashboard = new DashboardViewModel();

        dashboard.TotalMateriais = materiais.Count;

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
}
