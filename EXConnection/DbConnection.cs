using System;

namespace CsharpIntermediate
{
  public abstract class DbConnection
  {
    private string ConnectionString { get; set; }
    private TimeSpan Timeout { get; set; }
    public DbConnection(string command)
    {
      if (command is null)
      {
        throw new InvalidOperationException();
      }
      this.ConnectionString = command;
    }
    public abstract void Close();
    public abstract void Open();

  }
}