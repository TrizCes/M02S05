using banco.Model;
using banco.Services;

internal class Program
{
  private static void Main(string[] args)
  {
    ClienteService _clienteService = new ClienteService();
    string opcao = "";

    do
    {
      Console.WriteLine("........................................................................\n");
      Console.WriteLine("                       Bem vindo ao banco c#");
      Console.WriteLine("........................................................................\n");
      Console.WriteLine("________________________________________________________________________");
      Console.WriteLine("                    O que você deseja realizar hoje?");
      Console.WriteLine("                    * Digite : 1 - Abrir Conta");
      Console.WriteLine("                    * Digite : 2 - Consultar Conta");
      Console.WriteLine("                    * Digite : 3 - Listar Todas as contas");
      Console.WriteLine("                    * Digite : 4 - SAIR");
      Console.WriteLine("________________________________________________________________________\n");
      Console.Write("\n                       Digite uma opção :  ");
      opcao = Console.ReadLine();
      System.Console.WriteLine("\n");
      switch (opcao)
      {
        case "1":
          _clienteService.CriarConta();
          break;
        case "2":
          Console.Write("Digite o numero da conta:");
          var cliente = _clienteService.BuscarClientePorNumeroDeConta(Console.ReadLine());
          if (cliente == null)
          {
            Console.WriteLine("Conta não Cadastrada");
          }
          else
          {
            Console.WriteLine(cliente.ResumoCliente());
          }
          break;
        case "3":
          _clienteService.ExibirClientes();
          break;
        case "4":
          break;
        default:
          Console.WriteLine("Opção não encontrada. Tente novamente! \n\n\n");
          break;
      }
    } while (opcao != "4");
  }
}