using System;

class InvitadoInexistenteError: Exception
{
  //Defino constructor y llamo al de la clase madre
  public InvitadoInexistenteError(): base()
  {
  }
  //Sobrecarga de constructor --> versión con mensaje
  public InvitadoInexistenteError(string message): base(message)
  {
    Console.WriteLine(message);
  }
}

class CorreoInvalidoError: Exception
{
  public CorreoInvalidoError(): base()
  {
  }
  public CorreoInvalidoError(string message):base(message)
  {
    Console.WriteLine(message);
  }
}

class InvitadoMenordeEdad:Exception
{
  public InvitadoMenordeEdad():base()
  {
  }
  public InvitadoMenordeEdad(string message):base(message)
  {
    Console.WriteLine(message);
  }
}