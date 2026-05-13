namespace TicTacToe.Models;
public class Jugador
{
    //Atributos y encapsulamiento
public string Nombre { get; set; }
public string Simbolo { get; set; }
   //constructor
public Jugador(string nombre, string simbolo)
{
Nombre = nombre;
Simbolo = simbolo;
}
}