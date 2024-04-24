//normalize strings  


/*
 static string NormalizeString(string input) {


    return input.ToLower().Trim().Replace(",", "");


}




Console.WriteLine(NormalizeString("Hello There, BUDDY   "));

*/

using System.Text;

static String Reverse(String input) {

    if (string.IsNullOrEmpty(input)) { 

        return input;
    
    
    }

    StringBuilder reversed = new StringBuilder(input.Length);

    for (int i = input.Length - 1; i >= 0; i--) {

        reversed.Append(input[i]);

    
    
    }
    return reversed.ToString();





}

static String Reverse2(String input)
{

    if (string.IsNullOrEmpty(input))
    {

        return input;


    }
    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);

    

}


//Console.WriteLine(Reverse2("Hello World"));


