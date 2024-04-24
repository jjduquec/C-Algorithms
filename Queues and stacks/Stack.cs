using static System.Console;
using System.Collections.Generic;


namespace Queues_and_stacks;

public class Stack
{


    /* 
     * Stack works with LIFO : last in, first out  
     */


    public void Stack_Colections() {
    
        //creating a  stack 
        Stack<string> stack = new Stack<string>();
        WriteLine("Start Main");
        stack.Push("Main");
        WriteLine("Start Main");
        stack.Push("ResponseBuilder");
        stack.Push("CallExternalService");
        WriteLine("END" + stack.Pop());
        stack.Push("ParseExternalData");
        //getting out the last 
        WriteLine("END"+ stack.Pop());
        WriteLine("END" + stack.Pop());
        WriteLine("END" + stack.Pop());

        //stack.Peek() --> also removes the last element 
        //stack.Trypeek() --> ensures that stack is not empty without return error 
        string item;

        WriteLine(stack.TryPeek(out item));



    }

    public Stack() { }







}
