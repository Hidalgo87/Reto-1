

class Verificador
{
  public bool verificar_edad(Invitado invitado)
  {
    if(invitado.Edad >= 18)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool verificar_correo(Invitado invitado)
  {
    string email = invitado.Email;
    //correo que empieza con caracter alfabetico
    string[] info = email.Split("@");
    if (info.Length == 2)
    {
      string correo = info[0];
      email = info[1];
      if (verificar_alfabeto(correo))
      {
        info = email.Split(".");
        string dominio = info[0];
        if (dominio is "gmail" || dominio is "hotmail" || dominio is "live")
        {
          if (info.Length == 2) //NO ES .edu.co
          {
            string terminacion = info[1];
            if(terminacion is "com" || terminacion is "co" || terminacion is "org")
            {
              return true;
            }
            else
            {
              return false;
            }
          }
          else // POSIBLEMENTE ES .edu.co
          {
            string terminacion1 = info[1];
            string terminacion2 = info[2];
            if (terminacion1 is "edu" && terminacion2 is "co")
            {
              return true;
            }
            else
            {
              return false;
            }
          }
        }
        else
        {
          return false;
        }
      }
      else{
        return false;
      }
    }
    else
    {
      return false;
    }
  }
      

  bool verificar_alfabeto(string email)
  {
    string alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz";
    for(int i=0; i<alfabeto.Length; i++)
    {
      if (email.StartsWith(alfabeto[i]))
      {
        return true;
      }
    }
    return false;
  }
}