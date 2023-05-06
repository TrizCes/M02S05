using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banco.Model;

namespace banco.Interface
{
  public interface IClienteService
  {
    void CriarConta();
    Cliente BuscarClientePorNumeroDeConta(int numeroConta);
    void ExibirClientes();
  }
}