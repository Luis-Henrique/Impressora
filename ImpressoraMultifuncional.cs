
public class ImpressoraMultifuncional : Iescaneadora, Iimpressora, Icopiadora
{
    public string Escanear(string texto)
    {
        return $"Texto a escanear: {texto}";
    }

    public string Copiar(string texto)
    {
        return $"Texto a copiar: {texto}";
    }

    public string Imprimir(string texto)
    {
        return $"Texto a imprimir: {texto}";
    }
}