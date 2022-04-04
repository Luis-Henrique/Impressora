// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        var i = new ImpresoraComum();
        Console.WriteLine(i.Imprimir("Estou estudando C#"));

        var c = new ImpresoraCopiadora();
        Console.WriteLine(c.Copiar("Estou estudando C#"));
    }
}
