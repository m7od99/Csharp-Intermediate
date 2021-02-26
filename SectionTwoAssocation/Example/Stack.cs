using System;
namespace CsharpIntermediate
{
  public class Stack
  {
    private int MaxSize { get; set; } = 1000;
    private int Index { get; set; } = 0;
    private object[] _object { get; set; }

    public Stack()
    {
      _object = new object[MaxSize];
    }

    public void Push(object obj)
    {
      if (obj is null)
      {
        throw new InvalidOperationException();
      }
      
      _object[Index] = obj;
      Index++;
    }
    public object Pop()
    {
      if (Index > 0)
      {
        Index = Index - 1;
        return _object[Index];
      }

      else
      {
        throw new IndexOutOfRangeException();
      }
    }
    public void Clear()
    {
      Index = 0;
    }

  }
}