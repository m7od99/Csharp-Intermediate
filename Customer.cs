using System.Collections.Generic;
using System;
using System.Linq;

namespace CsharpIntermediate
{
  public class Customer
  {
    public Customer(string name, int id, int balance)
    {
      this.Name = name;
      this.Id = id;
      this.Balance = balance;

    }
    public string Name { get; set; }
    public int Id { get; set; }

    public int Balance { get; set; }


  }
}