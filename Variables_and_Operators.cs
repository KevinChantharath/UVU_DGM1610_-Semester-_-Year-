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

#Operators- operators perform operations on values and variables for example adding, subtraction multiplication, etc.
#Arithmetic Operator-used for common mathmematical operations
#After code is executed display the value of x which will be 100 after they add 50 and 50 together

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 50 + 50;
      Console.WriteLine(x);  
     }
  }
}

#Assign Operators-Their purpose to to assign values to variables
#When this code is executed it will display x which will have the value 5

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      Console.WriteLine(x);  
     }
  }
}

#