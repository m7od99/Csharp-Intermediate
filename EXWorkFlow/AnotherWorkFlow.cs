using System;
namespace CsharpIntermediate
{
  public class AnotherWorkFlow : IWorkFlow
  {
    public void Execute()
    {
      Console.WriteLine("Starting..");
      Console.WriteLine("Sending email...");
      Console.WriteLine("SaveFile");
      Console.WriteLine("Finish...");
    }
  }
}