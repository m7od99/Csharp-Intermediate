using System;
namespace CsharpIntermediate
{
  public class DbCommand
  {
    public DbCommand(DbConnection connection, string instruction)
    {
      if (connection is null || instruction is null)
      {
        throw new InvalidOperationException("its canout be null");
      }
      this.Connection = connection;
      this.Instruction = instruction;
    }
    private DbConnection Connection { get; set; }
    private string Instruction { get; set; }

    public void Execute()
    {
      Connection.Open();
      Console.WriteLine(Instruction);
      Connection.Close();
    }
  }
}