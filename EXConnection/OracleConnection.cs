namespace CsharpIntermediate
{
  public class OracleConnection : DbConnection
  {
    public OracleConnection(string command) : base(command)
    {
    }

    public override void Close()
    {
      System.Console.WriteLine("Oracle Connection is Close");
    }

    public override void Open()
    {
      System.Console.WriteLine("Oracle Connection is Open");
    }
  }
}