using System;

namespace SavingInterface
{
  class PasswordManager:IDisplayable,IResetable
  {
    string password;
    private string Password
    { 
      get
      {
        return password;
      }
      set
      {
        if(value.Length >= 8)
          password = value;
      }
    }

    public bool Hidden
    { get; private set; }

    public string HeaderSymbol
    {get; private set;}

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
      HeaderSymbol = "^^^^^^";
    }

    public void Display()
    {
      Console.WriteLine("Password");
      Console.WriteLine(HeaderSymbol);
      if(String.IsNullOrEmpty(Password))
      {
        Console.WriteLine("no password exists, must be at least 8 characters long");
      }
      else
      {
      if(Hidden == true)
        Console.WriteLine(Password);
      else
        Console.WriteLine("****");
      }
    }

    public void Reset()
    {
      Password = String.Empty;
      Hidden = false;
    }

    public bool ChangePassword(string oldPassword, string newPassword)
    {
      if(Password == oldPassword)
      {
        Password = newPassword;
        return true;
      }
      else
        return false;
    }
  }
}