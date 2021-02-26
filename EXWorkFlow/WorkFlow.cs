using System;
namespace CsharpIntermediate
{
  public class WorkFlow : IWorkFlow
  {
    public void Execute()
    {
      Console.WriteLine("Starting..");
      Console.WriteLine(DateTime.Today);
      Console.WriteLine("Sending email...");
      Console.WriteLine("Finish...");
    }
  }
}