using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Model
{
  public abstract class Cliente
  {
    private DateTime AberturaDeConta;
    protected double LimiteMaximo { get; set; }
    protected double Saldo { get; private set; }

    public string Nome { get; private set; }
    public string NumeroConta { get; private set; }
    public string Endereco { get; protected set; }

    public Cliente()
    {
      AberturaDeConta = DateTime.Now;
    }
    public Cliente(double limiteMaximo, double saldo, string numeroConta, string nome, string endereco) : this()
    {
      LimiteMaximo = limiteMaximo;
      Saldo = saldo;
      NumeroConta = numeroConta;
      Nome = nome;
      Endereco = endereco;

    }

    public virtual void ResumoCliente()
    {
      Console.WriteLine($"Conta: {NumeroConta}, Saldo: {Saldo}, Nome: {Nome}, Endereco: {Endereco}, Limite disponível: {LimiteMaximo}, Data de abertura: {AberturaDeConta}");
    }
  }
}