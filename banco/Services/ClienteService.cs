using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banco.Model;

namespace banco.Services
{
  public class ClienteService
  {
    public static List<Cliente> ListaClientes = new List<Cliente>();
    public void CriarConta()
    {
      Console.WriteLine("________________________________________________________________________");
      Console.WriteLine("                       Adicionando novo cliente");
      Console.WriteLine("                    Qual tipo de conta deseja criar?");
      Console.WriteLine("                    * Pessoa fisíca - Digite : 1");
      Console.WriteLine("                    * Pessoa juridica - Digite : 2");
      Console.WriteLine("                    * Para SAIR - Digite : 3");
      Console.WriteLine("________________________________________________________________________");
      string opcao;
      do
      {
        Console.Write("                               Digite a opção:  ");
        opcao = Console.ReadLine();
        if (opcao == "1") { CriarContaPessoaFisica(); } else if (opcao == "2") { CriarContaPessoaJuridica(); }
      } while (opcao != "3");


    }

    public string BuscarClientePorNumeroDeConta(string numeroConta)
    {
      ListaClientes.Find(cliente => cliente.NumeroConta == numeroConta);
      return "";
    }

    public void ExibirClientes()
    {
      Console.WriteLine("________________________________________________________________________");
      Console.WriteLine("                        Lista de Clientes:");
      Console.WriteLine("________________________________________________________________________");
      foreach (var clientes in ListaClientes)
      {
        clientes.ResumoCliente();
        Console.WriteLine("........................................................................");
      }
      Console.WriteLine("________________________________________________________________________");

    }
  }
}