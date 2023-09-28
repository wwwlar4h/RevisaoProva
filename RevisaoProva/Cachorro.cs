﻿public class Cachorro : Animal 
{
    public string nome { get; set; }
    public string raca { get; set; }

    public Cachorro(double tamanho, double peso, string nome, string raca): base(tamanho, peso) 
    {
        this.nome = nome;
        this.raca = raca;
        this.tamanho = tamanho; 
        this.peso = peso;   
    }

    public override void Barulho() //poliformismo 
    {
        Console.WriteLine("miau");
    }
}
