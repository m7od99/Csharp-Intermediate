namespace CsharpIntermediate
{
  public class SqlConnection : DbConnection
  {
    public SqlConnection(string command) : base(command)
    {
    }

    public override void Close()
    {
      System.Console.WriteLine("Sql Connection is Close");
    }

    public override void Open()
    {

      System.Console.WriteLine("Sql Connection is Open");
    }

  }
}