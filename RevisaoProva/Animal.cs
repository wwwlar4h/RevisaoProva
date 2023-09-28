public class Animal
{
    public double tamanho { get; set; }
    public double peso { get; set; }

    public Animal(double tamanho, double peso)
    {
        this.tamanho = tamanho;
        this.peso = peso;
    }

    public virtual void Barulho() //poliformismo base
    {
        Console.WriteLine("Barulho!");
    } 
}