using RevisaoProva;
using System;

class Heranca
{
    static void Main(string[] args)    
    {
        Animal a = new Animal(140, 40);

        Cachorro c = new Cachorro(140, 40, "zorão", "dogue alemão");
        Cachorro c1 = new Cachorro(140, 40, "sanjão", "pastor alemão");
        Cachorro c2 = new Cachorro(60, 10, "choppa", "chowchow");
        c.Barulho();

        Gato g = new Gato(60, 10, "Gatuna", "tigrado");
        Gato g1 = new Gato(60, 10, "Robina", "preta");

        Console.WriteLine(" nome: " + c.nome + "  -  "+  "tamanho: " +c.tamanho+"  -  " + "peso: "+c.peso+"  -  "+ "raça: "+ c.raca);
        Console.WriteLine(" nome: " + g.nome + "  -  " + "tamanho: " + g.tamanho + "  -  " + "peso: " + g.peso + "  -  " + "raça: "+ g.raca);
  
    
        List<Cachorro> listaCachorro = new List<Cachorro>();    
        listaCachorro.Add(c);
        listaCachorro.Add(c1);
        listaCachorro.Add(c2);


        List<Gato> listaGatitos = new List<Gato>();
        listaGatitos.Add(g);
        listaGatitos.Add(g1);

        listaCachorro = listaCachorro.OrderBy(x => x.nome).ToList(); //ordenar a lista
        List<Cachorro> listaComPesoGrande = listaCachorro.OrderBy(x => x.peso >= 40).ToList();    

        foreach (Cachorro cf in listaCachorro)
        {
            Console.WriteLine($"\nO nome do cachorro é {cf.nome} da raça {cf.raca}");
        }



    }
} 