using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      //tdl.Add("Learn C");
      //tdl.Add("Crochet");
      //tdl.Add("Reading");
      tdl.Display();
      //tdl.Reset();
      //tdl.Display();

      PasswordManager pm = new PasswordManager("iluvpies", true);
      pm.Display();
      bool isPasswordValue = pm.ChangePassword("iluvpies","iluvchoc");
      if(isPasswordValue)
      {
        pm.Display();
      }
      else
        Console.WriteLine("Unable to change password");
      //pm.Reset();
      //pm.Display();
    }
  }
}
