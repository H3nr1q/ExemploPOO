using ExemploPOO.Interfaces;
using ExemploPOO.Models;

//Abstração
// Pessoa p1 = new();
// p1.Nome = "Clara";
// p1.Idade = 3;

// p1.apresentar();


//Encapsulamento

// ContaCorrente c1 = new(123,1000);

// c1.ExibirSaldo();
// c1.Sacar(100);
// c1.ExibirSaldo();

// c1.Sacar(1000);


// HERANCA

// Professor p1 = new();
// p1.Nome = "Henrique";
// p1.Idade = 34;
// p1.Salario = 5000M;
// p1.Apresentar();


// Aluno a1 = new();
// a1.Nome = "Clara";
// a1.Idade = 3;
// a1.Nota = 10M;
// a1.Apresentar();

//Classe Abstract
// Corrente c = new();
// c.Creditar(500);
// c.ExibirSaldo();

// Computador c = new();
// Console.WriteLine(c.ToString());    

ICalculadora c = new Calculadora();
