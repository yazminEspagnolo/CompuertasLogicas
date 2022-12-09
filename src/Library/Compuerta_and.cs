namespace Library;
public class Compuerta_and : Compuerta
{
    public Compuerta_and (string nombre) : base(nombre)
    {
    }
    public int Resultado()
    {
        int valor = 1;
        foreach (var i in Entradas)
        {
            valor = (valor * i.Value); // Multiplica los valores de las entradas. Value es un metodo de la
                                       // clase Dictionary que devuelve el valor asociado con la clave especificada.
        }
        return valor;
    }
}