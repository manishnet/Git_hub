using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Class2
    {
    }

public class TextInput {
   public StringBuilder builder = new StringBuilder(100);    
    public virtual void Add(char c)
    {
        builder.Append(c);
        
    }
    public string GetValue()
    {
       return builder.ToString();
    }
    
}

public class NumericInput :TextInput
{
    public override void Add(char c)
    {
    if(Char.IsNumber(c))
    {
    
          builder.Append(c);
         
        }
    }
}

public class UserInput
{
    //public static void Main(string[] args)
    //{
    //    TextInput input = new NumericInput();
    //    input.Add('1');
    //    input.Add('a');
    //    input.Add('0');
    //    Console.WriteLine(input.GetValue());
    //}
}
}
