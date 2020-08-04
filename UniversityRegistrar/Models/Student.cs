using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public DateTime DateEnrolled {get;set;}
  }
}