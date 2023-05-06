using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Model
{
  public class PessoaFisica : Cliente
  {
    public DateTime DataDeAniversario { get; set; }

    public String Cpf { get; set; }

    public PessoaFisica() : base() { }

    public PessoaFisica(decimal limiteMaximo, string numeroConta, string nome, string endereco, string email, string telefone, DateTime dataDeAniversario, string cpf) : base(limiteMaximo, numeroConta, nome, endereco, email, telefone)
    {
      DataDeAniversario = dataDeAniversario;
      Cpf = cpf;
    }

    public override bool EhMaior()
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
    public override string ResumoCliente()
    {
      return $"{base.ResumoCliente()}, CPF: {Cpf}, Data de Nascimento: {DataDeAniversario} ";
    }
  }
}