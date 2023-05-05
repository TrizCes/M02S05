using banco.Model;
using banco.Services;

internal class Program
{
  private static void Main(string[] args)
  {
    ClienteService clienteService = new ClienteService();

    clienteService.CriarConta();
    clienteService.ExibirClientes();
  }
}