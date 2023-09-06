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
 #When code is executed it will display myNum value

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

#Boolean Variables store values of 2 states true or false
#When code is executed have options true or false 

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      bool isPlayingGamesFun = true;
      bool isHomeworkFun = false;
      Console.WriteLine(isPlayingGamesFun);   // Outputs True
      Console.WriteLine(isHomeworkFun);   // Outputs False    
    }
  }
}

#Float Variables store floating point numbers or numbers with decimals for example 0.99, 1.99 etc. 
#When code is executed display myDoubleNum value

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double myDoubleNum = 6.02D;
      Console.WriteLine(myDoubleNum);  
     }
  }
}