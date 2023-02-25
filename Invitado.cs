class Invitado
{
  string nombre;
  int id;
  string email;
  int edad;
  
  public Invitado(string nombre_i, int id_i, string email_i, int edad_i)
  {
    nombre = nombre_i;
    id = id_i;
    email = email_i;
    edad = edad_i;
  }

  public int Id
  {
  get{return id;}
  set{id = value;}
    }
  public string Nombre
  {
    get{return nombre;}
    set{nombre = value;}
  }
  public int Edad
  {
    get{return edad;}
    set{edad=value;}
  }
  public string Email
  {
    get{return email;}
    set{email=value;}
  }
}