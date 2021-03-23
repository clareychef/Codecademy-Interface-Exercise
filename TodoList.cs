using System;

namespace SavingInterface
{
  class TodoList:IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    public string HeaderSymbol
    {get; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
      HeaderSymbol = "------";
    }

    public void Add(string todo)
    {
      if(nextOpenIndex<5)
      {
        Todos[nextOpenIndex] = todo;
        nextOpenIndex++;
      }
      else
        Console.WriteLine("Error, to-do list is full");
    }

    public void Display()
    {
      Console.WriteLine("To Do List");
      Console.WriteLine(HeaderSymbol);
      foreach(string todo in Todos)
      {
        if(!String.IsNullOrEmpty(todo))
          Console.WriteLine(todo);
        else
          Console.WriteLine("[]");
      }
    }

    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
  }
}