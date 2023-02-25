using System;
using System.Collections.Generic;
using System.IO;

class Controlador
{
  public LectorArchivo lector;
  public Verificador verificador = new Verificador();
  public string detectar_archivo(string path_archivo)
  {
    if (path_archivo.Contains(".txt"))
    {
      Console.WriteLine("txt");
      string str = "	";
      lector = new TXT();
      return str;
    }
    else if (path_archivo.Contains(".csv"))
    {
      Console.WriteLine("csv");
      string str = ",";
      lector = new CSV();
      return str;
    }
    else
    {
      return null;
    }
  }

  public Invitado buscar_invitado(int id)
  {
    foreach(Invitado invitado in lector.list_invitados)
    {
      if (invitado.Id == id)
      {
        return invitado;
      }
    }
    return null;
  }

  public void run(string direccion, string separador){
    lector.leer_info(direccion, separador);
  }

  public void verificar_invitado(int id)
  {
    Invitado invitado = buscar_invitado(id);
    try{
    if (invitado != null)
    {
      if(verificador.verificar_edad(invitado))
      {
        if(verificador.verificar_correo(invitado))
        {
          Console.WriteLine("Está correctamente registrado y es apto para ingresar");
        }
        else
        {
          Console.WriteLine("Correo inválido");
        }
      }
      else
      {
        Console.WriteLine("Es menor de edad");
      }
    }
    else
    {
      throw new InvitadoInexistenteError("No existe un invitado con ese ID");
    }
  }
    catch (InvitadoInexistenteError)
    {
      Console.WriteLine("Ingrese nuevamente el ID"); //excepcion manejada lanzando de nuevo el input y la funcion
      int id_i = Program.solicitar_id();
      verificar_invitado(id_i);
    }
}
}