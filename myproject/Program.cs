// See https://aka.ms/new-console-template for more information
using System;

namespace myproject
{
  class Student
  {
    public int roll_no;
    public string name;
    public Student(string name,int roll_no)
    {
      this.name = name;
      this.roll_no = roll_no;
    }
    public void print()
    {
      Console.WriteLine("{0}-{1}",name,roll_no);
    }


  }
  class Program
  {
    static int factorial(int n)
    { 
      int fact  = 1;
      while(n>0)
      {fact = fact * n;
      n--;
      }
      return fact;
    }
    static void Main(String[] Args)
    {
      string s = "1";
      if (s=="1")
      {
        Console.WriteLine("Equal");
      }
      else
      {
        Console.WriteLine("NotEqual");
      }
      string[] m1 = new string[]{"Akant","Sumit"};
      Console.WriteLine(m1[1]);
    }
  }

}


