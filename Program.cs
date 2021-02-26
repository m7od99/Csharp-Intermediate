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

      var test = new Stack();
      test.Push(1);
      test.Push(5);
      Console.WriteLine(test.Pop());
      Console.WriteLine(test.Pop());

      var command = new DbCommand(new SqlConnection("hmm"), "DoSomething");
      command.Execute();
      var command2 = new DbCommand(new OracleConnection("hmm"), "do some thing");
      command2.Execute();

      var work = new WorkflowEngine();
      work.Run(new WorkFlow());
      work.Run(new AnotherWorkFlow());
    }
  }
}

