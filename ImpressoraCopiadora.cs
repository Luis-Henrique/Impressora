
public class ImpresoraCopiadora : Iimpressora, Icopiadora
{
    public string Imprimir(string texto)
    {
        return $"Texto a imprimir: {texto}";
    }

    public string Copiar(string texto)
    {
        return $"Texto a Copiar: {texto}";
    }
}