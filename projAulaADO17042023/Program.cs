using projAulaADO17042023.Controllers;
using projAulaADO17042023.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Proj MVC - ADO.NET");

        Console.WriteLine(" TESTE Inclusão de dados");

        AirPlane airPlane = new()
        {
            Description = "Para testes",
            Id = 1,
            Name = "TOP TURBO",
            NumberOfPassagers = 20,
            Engine = new() { Description = "motor" }
        };


        for (int i = 0; i < 5; i++)
        {

            if (new AirplaneControler().Insert(airPlane))
                Console.WriteLine("Sucesso!Registro Inserido!");
            else
                Console.WriteLine("Erro ao inserir registro");
        }

        new AirplaneControler().FindAll().ForEach(Console.WriteLine);
    }
}