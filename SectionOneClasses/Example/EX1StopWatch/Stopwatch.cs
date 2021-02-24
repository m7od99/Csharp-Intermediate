using System;
namespace CsharpIntermediate
{
  public class Stopwatch
  {
    private DateTime Start { get; set; }
    private DateTime Stop { get; set; }

    private TimeSpan StartTime()
    {
      Enter("start");
      Start = DateTime.Now;
      var time = TimeSpan.Parse(Start.ToString("h:m:s"));
      return time;
    }

    private TimeSpan StopTime()
    {
      Enter("stop");
      Stop = DateTime.Now;
      var time = TimeSpan.Parse(Stop.ToString("h:m:s"));
      return time;
    }
    public void StopWatch()
    {
      var d = "";
      while (d == "")
      {
        MainStopWatch();
        Console.WriteLine("To Out Enter any later , or press Enter to Continue");
        d = Console.ReadLine();
      }
    }

    private void MainStopWatch()
    {
      var start = StartTime();
      var stop = StopTime();
      Duration(start, stop);
    }

    private void Duration(TimeSpan start, TimeSpan stop)
    {
      var duration = stop - start;
      Console.WriteLine($"The Duration : {duration}");
    }

    private void Enter(string input)
    {
      Console.Write($"Enter To {input}");
      Console.ReadLine();
    }

  }
}