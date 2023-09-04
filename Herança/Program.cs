/* 
• É um tipo de associação que permite que uma classe herde dados e comportamentos de outra -> pwemite o reuso de atributos e metodos (dados e comportamento)

• Definições importantes

• Vantagens
    • Reuso (de dados e metodos, etc de outra classe)
    • Polimorfismo

• Sintaxe
    • : (estende)
    • base (referência para a superclasse)

• Relação "é-um" (uma coisa é  uma outra só que com algo a mais)

• Generalização/especialização (uma classe derivada (especializada) é uma generealização - mais abrangente - de outra)

• Superclasse (classe base - é a generelização) / subclasse (classe derivada - é a classe especializada que deriva da superclasse )

• Herança - > é a extensão de outra classe (a superclasse tem tudo que a subclasse tem)

• Herança é uma associação entre classes (e não entre objetos) */

using System;
using System.Collections.Generic;
using System.Text;
using Herança.Entities;

namespace Herança {
    class program {
        static void Main(string[] args) {

            BussinesAccount account = new BussinesAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

           // account.Balance = 200.0; -> deu erro pois o protected nao deixa o programa principal alterar o valor somente a propria classe, as subclassses no assembly e subclasses fora do assembly
        }
    }
}


