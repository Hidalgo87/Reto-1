using System;
using System.Collections.Generic;
using System.IO;

class TXT:LectorArchivo
{
  public override void leer_info(string path, string separador)
  {
    StreamReader sr = new StreamReader(path);
    sr.BaseStream.Seek(0, SeekOrigin.Begin);
    string content = sr.ReadLine(); //IGNORAMOS LA PRIMERA LINEA
    content = sr.ReadLine();
    while (content != null)
    {
      string[] info = content.Split(separador);
      string nombre = info[0];
      int id = Convert.ToInt32(info[1]);
      string email = info[2];
      int edad = Convert.ToInt32(info[3]);
      Invitado invitado = new Invitado(nombre, id, email, edad);
      this.list_invitados.Add(invitado);
      content = sr.ReadLine();
    }
    sr.Close();
  }
}