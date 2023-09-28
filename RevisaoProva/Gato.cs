using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProva
{
    internal class Gato: Animal 
    {
        public string nome { get; set; }    
        public string raca { get; set; }    

        public Gato(double tamanho, double peso, string nome, string raca): base(tamanho, peso)
        {
            this.nome = nome;   
            this.raca = raca;   
        }

        public override void Barulho() //poliformismo 
        {
            Console.WriteLine("auau");
        }

    }
}
