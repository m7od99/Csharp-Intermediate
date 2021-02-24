using System;
using System.Collections.Generic;
namespace CsharpIntermediate
{
  public class Post
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime CreatedDate { get; set; }

    private int UpVote { get; set; }

    private int DownVote { get; set; }

    public void DoDownVote()
    {
      DownVote++;
    }

    public void DoUpVote()
    {
      UpVote++;
    }

    public void ShowCurrentVote()
    {
        Console.WriteLine($"Up Vote : {UpVote} || Down Vote {DownVote}");
    }




  }
}