using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
           //Criando a lista
           List<Produto> produtos = new List<Produto>();

           //Adicionado itens a lista instaciando eles
           produtos.Add(new Produto(1,"FIFA20", 129.99f));
           produtos.Add(new Produto(2,"GTA V", 79.99f));
           produtos.Add(new Produto(3,"Far Cry 5", 129.99f));
           produtos.Add(new Produto(4,"The Last of Us II", 239.99f));
           produtos.Add(new Produto(5,"Sea of Thieves", 89.99f));

           // ou um por um usando instâncias básicas e seus atributos
           Produto reddead = new Produto();
           reddead.Codigo = 6;
           reddead.Nome = "Red Dead Redemption 2";
           reddead.Preco = 249.99f;

           produtos.Add(reddead);

           //mostrando itens da lista com o FOREACH
           foreach(Produto p in produtos){
               Console.WriteLine($"{p.Nome} - {p.Preco}");
            }
            //podemos remove um item pelo seu índice no se array/arranjo
            produtos.RemoveAt(4);

            //podemos tbm remover da lista usando lambda e o método removeAll:
            produtos.RemoveAll(x => x.Nome == "Sea of Thieves");

            Console.WriteLine("\nLista Alterada: ");
            //checamos se foi alterada
            foreach(Produto p in produtos){
                System.Console.WriteLine($"{p.Nome} - {p.Preco} ");
            }
        }
    }
}
