using System;

namespace CsharpIntermediate
{
  class Program
  {
    static void Main(string[] args)
    {
      var person = new Person();
      person.FirstName = "Cal";
      person.LastName = "Vina";
      person.Age = 25;
      Console.WriteLine(person.FullName);

      Stopwatch s = new Stopwatch();
      //s.StopWatch();

      Post post = new Post();
      post.DoUpVote();
      post.DoUpVote();
      post.DoUpVote();
      post.DoUpVote();
      post.DoDownVote();
      post.DoDownVote();
      post.DoDownVote();
      post.DoDownVote();
      post.DoDownVote();
      post.ShowCurrentVote();


    }
  }
}

