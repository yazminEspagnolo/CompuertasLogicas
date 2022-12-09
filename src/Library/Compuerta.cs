namespace Library;
public class Compuerta

{
    public Compuerta(string nombre)
    {
        this.Entradas = new Dictionary<string, int>(); // Inicializa el diccionario (Un diccionario es una estructura de datos que permite almacenar pares de valores).   
        this.Nombre = nombre;
    }
    public Dictionary<string, int> Entradas { get; set; }
    public string Nombre { get; set; }
   
    public void AgregarEntrada(string nombre, int valor)
    {
        if (valor != 0) 
        {
            valor = 1;
        }
        else 
        {
            valor = 0;
        }


        if (!Entradas.ContainsKey(nombre)) //Si nombre no esta en el diccionario lo agrega. ContainKey es un metodo de la clase Dictionary que devuelve true si el diccionario contiene la clave especificada.
        {
            Entradas.Add(nombre, valor);
        }
        else 
        {
            Entradas[nombre] = valor;    // Si nombre esta en el diccionario, actualiza el valor de la entrada.         
        }        
    }
}