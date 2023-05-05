using banco.Model;

Cliente cliente01 = new PessoaFisica(80000, "12345", "Mariana", "Rua três", "mariana@email.com", "(47)98888-9999", new DateTime(1998, 07, 03), "456789123-58");

Console.WriteLine(cliente01.Nome);

var ehMaior = cliente01.EhMaior();

Console.WriteLine(ehMaior);

Cliente cliente02 = new PessoaFisica(80000, "12345", "Selma", "Rua três", "mariana@email.com", "(47)98888-9999", new DateTime(2005, 05, 05), "456789123-58");

Console.WriteLine(cliente02.Nome);

var ehMaior2 = cliente02.EhMaior();

Console.WriteLine(ehMaior2);