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
      string opcao;
      do
      {
        Console.WriteLine("________________________________________________________________________");
        Console.WriteLine("                       Adicionando novo cliente");
        Console.WriteLine("                    Qual tipo de conta deseja criar?");
        Console.WriteLine("                    * Pessoa fisíca - Digite : 1");
        Console.WriteLine("                    * Pessoa juridica - Digite : 2");
        Console.WriteLine("                    * Para SAIR - Digite : 3");
        Console.WriteLine("________________________________________________________________________");

        Console.Write("\n                              Digite uma opção :  ");
        opcao = Console.ReadLine();
        System.Console.WriteLine("\n");
        if (opcao == "1")
        {
          CriarContaPessoaFisica();
        }
        else if (opcao == "2")
        {
          //CriarContaPessoaJuridica(); 
        }
        Console.Write("\n");
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

    public void CriarContaPessoaFisica()
    {
      PessoaFisica NewCliente = new PessoaFisica();
      Console.WriteLine("........................................................................");
      Console.Write("Qual é a DATA DE NASCIMENTO do cliente?(ano - mês - dia) Digite: ");
      NewCliente.DataDeAniversario = DateTime.Parse(Console.ReadLine());
      if (!NewCliente.EhMaior())
      {
        return;
      }
      Console.Write("Qual é o NOME do cliente? Digite: ");
      NewCliente.Nome = Console.ReadLine();
      Console.Write("Qual é o CPF do cliente? Digite: ");
      NewCliente.Cpf = Console.ReadLine();
      Console.Write("Qual é o ENDEREÇO do cliente? Digite: ");
      NewCliente.Endereco = Console.ReadLine();
      Console.Write("Qual é o TELEFONE do cliente? Digite: ");
      NewCliente.Telefone = Console.ReadLine();
      Console.Write("Qual é o EMAIL do cliente? Digite: ");
      NewCliente.Email = Console.ReadLine();
      Console.Write("Qual é o SALDO INICIAL de abertura da conta? Digite: ");
      NewCliente.Saldo = decimal.Parse(Console.ReadLine());
      Console.Write("Qual é o LIMITE pré aprovado para o cliente? Digite: ");
      NewCliente.LimiteMaximo = decimal.Parse(Console.ReadLine());
      Console.Write("Qual é o NUMERO DA CONTA do cliente? Digite: ");
      NewCliente.NumeroConta = Console.ReadLine() + " - 1";
      try
      {
        ListaClientes.Add(NewCliente);
        Console.WriteLine("........................................................................");
        Console.WriteLine($"               Cliente cadastrado com sucesso!");
        Console.WriteLine("........................................................................");
      }
      catch (Exception) { Console.Write("Erro no cadastro"); }


    }
  }
}