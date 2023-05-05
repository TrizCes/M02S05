using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Model
{
  public abstract class Cliente
  {
    private DateTime AberturaDeConta;
    protected decimal LimiteMaximo { get; set; }
    protected decimal Saldo { get; set; }
    public string Nome { get; set; }
    public string NumeroConta { get; set; }
    public string Endereco { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public Cliente()
    {
      AberturaDeConta = DateTime.Now;
    }
    public Cliente(decimal limiteMaximo, string numeroConta, string nome, string endereco, string email, string telefone) : this()
    {
      LimiteMaximo = limiteMaximo;
      NumeroConta = numeroConta;
      Nome = nome;
      Endereco = endereco;
      Email = email;
      Telefone = telefone;
    }

    public virtual void ResumoCliente()
    {
      Console.WriteLine($"Conta: {NumeroConta}, Saldo: {Saldo}, Nome: {Nome}, Endereco: {Endereco}, Email: {Email}, Telefone: {Telefone} Limite disponível: {LimiteMaximo}, Data de abertura: {AberturaDeConta}");
    }
  }
}