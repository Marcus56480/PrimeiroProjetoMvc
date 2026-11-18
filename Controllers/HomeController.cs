using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // A view index lê essa chave para exibir a mensagem
        ViewData["Mensagem"] = "Bem Vindo ao Sistema!";
        return View();
    }

    // Action que recebe parametro pela rota: /Home/Sobre/5 (Valor qualquer)
    public IActionResult Sobre(int? id)
    {
        ViewBag.Versao = "1.0";
        ViewBag.ParametroId = id;
        return View();
    }

    // Action que recebe parametros via query string: /Home/Saudacao?nome=Marcus
    public IActionResult Saudacao(string nome)
    {
        // Model Binding obtem nome da URL; Usa "Visitante se nada for informado"
        ViewData["Nome"] = nome ?? "Visitante";
        return View();
    }
}
