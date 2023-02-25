using System;
using System.Collections.Generic;
using System.IO;

abstract class LectorArchivo
{
  public List<Invitado> list_invitados = new List<Invitado>();
  public abstract void leer_info(string path, string separador);
}