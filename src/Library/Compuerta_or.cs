namespace Library;
public class Compuerta_or : Compuerta
{
    public Compuerta_or(string nombre) : base(nombre)
    { 
    }
    
    public int Resultado()
    {
        int resultado = 0;
        foreach (var i in Entradas)
        {   
            if (i.Value == 1)
            {
                resultado = 1;
            }
            else if (i.Value == 0 && resultado == 0)
            {
                resultado = 0;
            }
        }
        return resultado;
    }
}