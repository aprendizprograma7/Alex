using Microsoft.AspNetCore.Mvc;
using SistemaControleMateriaisWeb.Data;
using SistemaControleMateriaisWeb.Models;

namespace SistemaControleMateriaisWeb.Controllers;

public class MateriaisController : Controller
{
    private readonly BancoDados Banco;

    public MateriaisController(BancoDados banco)
    {
        Banco = banco;
    }

    public IActionResult Index()
    {
        List<Material> materiais = Banco.ListarMateriais();

        return View(materiais);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Material material)
    {
        if (!ModelState.IsValid)
        {
            return View(material);
        }

        Banco.SalvarMaterial(material);

        TempData["Mensagem"] = "Material cadastrado com sucesso!";

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        Material? material = Banco.BuscarMaterialPorId(id);

        if (material == null)
        {
            return NotFound();
        }

        return View(material);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Material? material = Banco.BuscarMaterialPorId(id);

        if (material == null)
        {
            return NotFound();
        }

        return View(material);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Material material)
    {
        if (id != material.Id)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return View(material);
        }

        bool alterado = Banco.AlterarMaterial(material);

        if (!alterado)
        {
            return NotFound();
        }

        TempData["Mensagem"] = "Material alterado com sucesso!";

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Material? material = Banco.BuscarMaterialPorId(id);

        if (material == null)
        {
            return NotFound();
        }

        return View(material);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        bool excluido = Banco.ExcluirMaterial(id);

        if (!excluido)
        {
            return NotFound();
        }

        TempData["Mensagem"] = "Material excluído com sucesso!";

        return RedirectToAction(nameof(Index));
    }
}