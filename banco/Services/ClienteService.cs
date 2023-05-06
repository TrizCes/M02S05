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

        Console.Write("\n                           Digite uma opção :  ");
        opcao = Console.ReadLine();
        System.Console.WriteLine("\n");
        if (opcao == "1")
        {
          CriarContaPessoaFisica();
        }
        else if (opcao == "2")
        {
          CriarContaPessoaJuridica();
        }
        Console.Write("\n");
      } while (opcao != "3");


    }

    public Cliente BuscarClientePorNumeroDeConta(string numeroConta)
    {
      return ListaClientes.Find(cliente => cliente.NumeroConta == numeroConta);
    }

    public void ExibirClientes()
    {
      Console.WriteLine("________________________________________________________________________");
      Console.WriteLine("                        Lista de Clientes:");
      Console.WriteLine("________________________________________________________________________");
      foreach (var clientes in ListaClientes)
      {
        Console.WriteLine(clientes.ResumoCliente());
        Console.WriteLine("........................................................................");
      }
      Console.WriteLine("________________________________________________________________________");

    }

    public void CriarContaPessoaFisica()
    {
      PessoaFisica NewCliente = new PessoaFisica();
      string digitoVerificador = " - 1";
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
      NewCliente = (PessoaFisica)CadastroBaseCliente(digitoVerificador, NewCliente);
      try
      {
        ListaClientes.Add(NewCliente);
        Console.WriteLine("........................................................................");
        Console.WriteLine($"               Cliente cadastrado com sucesso!");
        Console.WriteLine("........................................................................");
      }
      catch (Exception) { Console.Write("Erro no cadastro"); }

    }

    public void CriarContaPessoaJuridica()
    {
      PessoaJuridica NewCliente = new PessoaJuridica();
      string digitoVerificador = " - 2";
      Console.Write("Qual é o NOME do responsável pela abertura da conta PJ? Digite: ");
      NewCliente.Nome = Console.ReadLine();
      Console.Write("Qual é a Razão Social da Pessoa Juridica? Digite: ");
      NewCliente.RazaoSocial = Console.ReadLine();
      Console.Write("Qual é o CNPJ do cliente? Digite: ");
      NewCliente.CNPJ = Console.ReadLine();
      Console.Write("Qual é a INSCRIÇÃO ESTADUAL? Digite: ");
      NewCliente.CNPJ = Console.ReadLine();
      NewCliente = (PessoaJuridica)CadastroBaseCliente(digitoVerificador, NewCliente);
      try
      {
        ListaClientes.Add(NewCliente);
        Console.WriteLine("........................................................................");
        Console.WriteLine($"               Conta PJ cadastrada com sucesso!");
        Console.WriteLine("........................................................................");
      }
      catch (Exception) { Console.Write("Erro no cadastro"); }
    }

    public Cliente CadastroBaseCliente(string digitoVerificador, Cliente cliente)
    {
      Console.Write("Qual é o ENDEREÇO do cliente? Digite: ");
      cliente.Endereco = Console.ReadLine();
      Console.Write("Qual é o TELEFONE do cliente? Digite: ");
      cliente.Telefone = Console.ReadLine();
      Console.Write("Qual é o EMAIL do cliente? Digite: ");
      cliente.Email = Console.ReadLine();
      Console.Write("Qual é o SALDO INICIAL de abertura da conta? Digite: ");
      cliente.Saldo = decimal.Parse(Console.ReadLine());
      Console.Write("Qual é o LIMITE pré aprovado para o cliente? Digite: ");
      cliente.LimiteMaximo = decimal.Parse(Console.ReadLine());
      Console.Write("Qual é o NUMERO DA CONTA do cliente? Digite: ");
      cliente.NumeroConta = Console.ReadLine() + digitoVerificador;
      return cliente;
    }
  }
}
