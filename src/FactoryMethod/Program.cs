// See https://aka.ms/new-console-template for more information
using FactoryMethod.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Cliente cliente = new Cliente();

        cliente.Main();
    }
}