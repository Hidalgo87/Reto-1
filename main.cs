using System;

class Program 
{
  public static void Main (string[] args) 
  {
    //string direccion = "Taller_herencia.txt"
    string direccion = "Taller_herencia.csv"; //Ingresar el path al archivo que se desee
    Controlador controlador = new Controlador();
    string separador = controlador.detectar_archivo(direccion);
    if (separador != null)
    {
    controlador.run(direccion, separador);
    int id = solicitar_id();
    //int id = 39607678;
    controlador.verificar_invitado(id);
    }
    else{
      Console.WriteLine("ERROR SEPARADOR NULO");
    }
  }

  public static int solicitar_id()
  {
    Console.WriteLine("Ingrese el ID del invitado a verificar");
    try
    {
    int id = Convert.ToInt32(Console.ReadLine());
    return id;
    }
    catch
    {
      Console.WriteLine("Ingrese solo numeros sin espacios");
      return solicitar_id();
    }
  }
}