namespace consumo;

public class Program
{
    static void Main(string[] args)
    {

        //Fazer um programa para ler a distância total(em km) percorrida por um carro, bem como o total de combustivel
        //gasto por este carro ao percorrer tal distancia.
        //Seu programa deve mostrar o consumo medio do carro.

        double distancia, combustivel, consumo;

        Console.WriteLine("Entre com o valor da distancia.");
        Console.Write("Distancia = ");
        distancia = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Agora entre com o valor do combustivel gasto.");
        Console.Write("Combustivel = ");
        combustivel = double.Parse(Console.ReadLine());

        consumo = distancia / combustivel;

        Console.WriteLine("O consumo medio é de = " + consumo.ToString());

    }
}