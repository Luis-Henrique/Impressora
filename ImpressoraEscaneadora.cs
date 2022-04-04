
public class ImpressoraEscaneadora : Iescaneadora
{
    public string Escanear(string texto)
    {
        return $"Texto a imprimir: {texto}";
    }
}