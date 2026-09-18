using Microsoft.AspNetCore.Mvc;
using SistemaControleMateriais_flp.Data;
using SistemaControleMateriais_flp.Models;

namespace SistemaControleMateriais_flp.Controllers;

public class MateriaisController : Controller
{
    private readonly BancoDados banco;

    public MateriaisController(BancoDados banco)
    {
        this.banco = banco;
    }

    public IActionResult Index()
    {
        return View(banco.ListarMateriais());
    }

    [HttpGet]
    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Material material)
    {
        if (!ModelState.IsValid)
        {
            return View(material);
        }

        banco.SalvarMaterial(material);
        TempData["Mensagem"] = "Material cadastrado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        Material? material = banco.BuscarMaterialPorId(id);
        return material is null ? NotFound() : View(material);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Material? material = banco.BuscarMaterialPorId(id);
        return material is null ? NotFound() : View(material);
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

        if (!banco.AlterarMaterial(material))
        {
            return NotFound();
        }

        TempData["Mensagem"] = "Material alterado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Material? material = banco.BuscarMaterialPorId(id);
        return material is null ? NotFound() : View(material);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        if (!banco.ExcluirMaterial(id))
        {
            return NotFound();
        }

        TempData["Mensagem"] = "Material excluído com sucesso!";
        return RedirectToAction(nameof(Index));
    }
}
