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