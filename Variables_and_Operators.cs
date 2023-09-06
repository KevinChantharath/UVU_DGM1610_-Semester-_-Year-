#Variables-containers for storing data values

#This is a String variable and it is used to store text and phrases for example "Hello world" or names like "Kevin" 
#They are also always surrounded by ""
#When the program is executed it will print out my name Kevin
 
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Kevin";
      Console.WriteLine(name);  
     }
  }
}
 
 #Integer Variable- stores whole numbers that aren't decimals like 100 or -100
 #When code is executed it will display the number 7

 using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 15;
      Console.WriteLine(myNum);
     }
  }
}

