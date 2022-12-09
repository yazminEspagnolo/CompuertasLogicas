using Library;
public class Program
{
    public static void Main(string[] args)
    {
        Compuerta_and and1 = new Compuerta_and("AND-1");
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 1);

        Compuerta_or or2 = new Compuerta_or("OR-2");
        or2.AgregarEntrada("C", 0);
        or2.AgregarEntrada(and1.Nombre, and1.Resultado());

        Compuerta_not not3 = new Compuerta_not("NOT-3");
        not3.AgregarEntrada(or2.Nombre, or2.Resultado());
        
        Console.WriteLine(not3.Resultado());
    }
}