// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        var i = new ImpresoraComum();
        Console.WriteLine(i.Imprimir("Estou estudando C#"));

        var c = new ImpresoraCopiadora();
        Console.WriteLine(c.Copiar("Estou estudando C#"));

        var e = new ImpressoraEscaneadora();
        Console.WriteLine(e.Escanear("Estou estudando C#"));

        var m = new ImpressoraMultifuncional();
        Console.WriteLine(m.Escanear("Estou estudando C#"));
        Console.WriteLine(m.Imprimir("Estou estudando C#"));
        Console.WriteLine(m.Copiar("Estou estudando C#"));

        CopiarDocumento(new Xerox(), "Estou estudando C#");
    }

    public static void CopiarDocumento(Icopiadora c, string texto)
    {
        Console.WriteLine("" + c.Copiar(texto));
    }
}
