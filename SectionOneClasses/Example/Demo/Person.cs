using System;

namespace CsharpIntermediate
{
  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
      get { return $"{FirstName} {LastName}"; }
    }

    public int Age { get; set; }
    public DateTime _birthday { get; set; }

    public string Email()
    {
      if (FirstName == null)
      {
        throw new NullReferenceException();
      }
      return $"{FirstName.Substring(0, 1)}{LastName}{Age}@Calorg.com";
    }
  }
}