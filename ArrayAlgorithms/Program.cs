// See https://aka.ms/new-console-template for more information


/*
static int? LinearSearch(int[] input, int n) {


    foreach (int current in input) {

        if (n == current) {

            return n;
        }
    
    
    }

    return null;



}


int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
Console.WriteLine(LinearSearch(arr,8));
int item= Array.Find(arr, element => element == 3);
int[] items =Array.FindAll(arr, element => element >= 5);
Array.ForEach(items, Console.WriteLine);

*/


/* 
 * Binary search:  
 *  A divide-and conquer algorithm where in each step it halves the number of elements it has to search 
 *  through 
 * 
 */

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
//Array.Binarysearch(array,start index, array size, item to search)
Array.BinarySearch(arr, 0, arr.Length, 4);