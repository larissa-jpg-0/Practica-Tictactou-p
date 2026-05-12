using System.Windows;
using System.Windows.Controls;
using TicTacToe.Models;
namespace TicTacToe;
public partial class MainWindow : Window
{
Juego juego;
public MainWindow()
{
InitializeComponent();
juego = new Juego();
}
private void Button_Click(object sender, RoutedEventArgs e)
{
Button boton = sender as Button;
int posicion = int.Parse(boton.Name.Replace("B", ""));
bool movimientoValido = juego.Jugar(posicion);
if (!movimientoValido)
{
MessageBox.Show("Casilla ocupada");
return;
}
boton.Content = juego.JugadorActual.Simbolo;
if (juego.HayGanador())
{
MessageBox.Show($"{juego.JugadorActual.Nombre} ganó");
DesactivarBotones();
return;
}
juego.CambiarTurno();
}
private void DesactivarBotones()
{
B0.IsEnabled = false;
B1.IsEnabled = false;
B2.IsEnabled = false;
B3.IsEnabled = false;
B4.IsEnabled = false;
B5.IsEnabled = false;
B6.IsEnabled = false;
B7.IsEnabled = false;
B8.IsEnabled = false;
}
}