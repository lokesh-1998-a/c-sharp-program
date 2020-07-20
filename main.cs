using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
  string n;
  int i;
  string s=string.Empty;
  n=Console.ReadLine();
  for(i=0;i<n.Length;i++)
  {
    s=n[i]+s;
  }
  Console.WriteLine(s);
  }
}
