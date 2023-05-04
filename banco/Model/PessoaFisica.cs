using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Model
{
  public class PessoaFisica : Cliente
  {
    public DateTime DataDeAniversario { get; private set; }

    public String Cpf { get; private set; }

    public PessoaFisica() : base() { }
    public bool EhMaior()
    {
      DateTime hoje = DateTime.Now;
      DateTime ObterIdadeMin = new DateTime(DataDeAniversario.Year + 18, DataDeAniversario.Month, DataDeAniversario.Day);
      if (hoje >= ObterIdadeMin)
      {
        Console.WriteLine("Cliente maior de idade, podemos prosseguir com abertura da conta.");
        return true;
      }
      else
      {
        Console.WriteLine("Cliente menor de idade, não podemos realizar a abertura de conta.");
        return false;
      }
    }
  }
}