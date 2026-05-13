namespace TicTacToe.Models;
public class Tablero
{

//Atributos y encapsulamiento
public string[] Casillas { get; set; }

//Cosntructor
public Tablero()
{
Casillas = new string[9];
for(int i = 0; i < Casillas.Length; i++)
{
Casillas[i] = "";
}
}

//Metodos
public bool ColocarSimbolo(int posicion, string simbolo)
{
if (Casillas[posicion] == "")
{
Casillas[posicion] = simbolo;
return true;
}
return false;
}
public bool VerificarGanador(string simbolo)
{
int[,] combinaciones =
{
{0,1,2},
{3,4,5},
{6,7,8},
{0,3,6},
{1,4,7},
{2,5,8},
{0,4,8},
{2,4,6}
};
for(int i = 0; i < combinaciones.GetLength(0); i++)
{
if(
Casillas[combinaciones[i,0]] == simbolo &&
Casillas[combinaciones[i,1]] == simbolo &&
Casillas[combinaciones[i,2]] == simbolo
)
{
return true;
}
}
return false;
}

public bool DetectarEmpate(string simbolo)
    {   
        int contador_empate = 0;
        int[,] combinaciones =
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        for(int i = 0; i < combinaciones.GetLength(0); i++)
        {
            if(
                Casillas[combinaciones[i,0]] == "" ||
                Casillas[combinaciones[i,1]] == "" ||
                Casillas[combinaciones[i,2]] == ""
            )
            {
                return false;
            }
            if(
                Casillas[combinaciones[i,0]] == simbolo &&
                Casillas[combinaciones[i,1]] == simbolo &&
                Casillas[combinaciones[i,2]] == simbolo
            )
            {
                contador_empate++;
            }
        }

        if (contador_empate == 0)
        {
            return true;
        }
        return false;
    }

}