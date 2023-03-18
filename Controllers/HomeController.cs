using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using atividade_5_mvc.Models;

namespace atividade_5_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        //instancias do tipo cliente
        Cliente cliente1 = new Cliente (01, "Jorge", "123.456.789.00", "meuemail@ponto.com","tatá");
        Cliente cliente2 = new Cliente (02, "Lincoln", "223.456.789.00", "seuemail@ponto.com","tete");
        Cliente cliente3 = new Cliente (03, "Sousa", "323.456.789.00", "teuemail@ponto.com","titi");
        Cliente cliente4 = new Cliente (04, "Galvão", "423.456.789.00", "deleemail@ponto.com","totó");
        Cliente cliente5 = new Cliente (05, "Nogueira", "523.456.789.00", "desteemail@ponto.com","tutu");

        //Lista de Clientes e atribui os clientes
        List<Cliente> listasClientes = new List<Cliente>();
        listasClientes.Add(cliente1);
        listasClientes.Add(cliente2);
        listasClientes.Add(cliente3);
        listasClientes.Add(cliente4);
        listasClientes.Add(cliente5);

        ViewBag.listasClientes = listasClientes;

        //instancias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor (01, "Jorge", "12.345.678./0001-00", "for01@ponto.com");
        Fornecedor fornecedor2 = new Fornecedor (02, "Lincoln", "13.345.678./0001-00", "for02@ponto.com");
        Fornecedor fornecedor3 = new Fornecedor (03, "Sousa", "15.345.678./0001-00", "for03@ponto.com");
        Fornecedor fornecedor4 = new Fornecedor (04, "Galvão", "14.345.678./0001-00", "for04@ponto.com");
        Fornecedor fornecedor5 = new Fornecedor (05, "Nogueira", "11.345.678./0001-00", "for05@ponto.com");

        //Lista de Fornecedor e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag. listasFornecedores = listaFornecedores;

        return View();
    }

  private Fornecedor Fornecedores(int v1, string v2, string v3, string v4)
  {
    throw new NotImplementedException();
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

  private class Fornecedor
  {
    private int v1;
    private string v2;
    private string v3;
    private string v4;

    public Fornecedor(int v1, string v2, string v3, string v4)
    {
      this.v1 = v1;
      this.v2 = v2;
      this.v3 = v3;
      this.v4 = v4;
    }
  }
}

internal class Fornecedores
{
}
internal class Cliente
{
  public Cliente(int v1, string v2, string v3, string v4, string v5)
  {
    V1 = v1;
    V2 = v2;
    V3 = v3;
    V4 = v4;
    V5 = v5;
  }

  public int V1 { get; }
  public string V2 { get; }
  public string V3 { get; }
  public string V4 { get; }
  public string V5 { get; }
}