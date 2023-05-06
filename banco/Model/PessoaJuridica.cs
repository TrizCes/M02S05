using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banco.Model;

namespace banco.Model
{
  public class PessoaJuridica : Cliente
  {
    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }
    public string InscricaoEstadual { get; set; }

    public PessoaJuridica()
    {

    }

    public PessoaJuridica(decimal limiteMaximo, string numeroConta, string nome, string endereco, string email, string telefone,
                        string cnpj, string razaoSocial, string inscricaoEstadual)
                        : base(limiteMaximo, numeroConta, nome, endereco, email, telefone)
    {
      CNPJ = cnpj;
      RazaoSocial = razaoSocial;
      InscricaoEstadual = inscricaoEstadual;
    }
    public override string ResumoCliente()
    {
      return $"{base.ResumoCliente()}, CNPJ: {CNPJ}, Razão Social: {RazaoSocial}, I.E.: {InscricaoEstadual}";
    }
  }
}