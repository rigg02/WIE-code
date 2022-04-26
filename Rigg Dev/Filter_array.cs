//Using arrays and foreach loop to take an array from user and filter the array for value above 50
using System;
{
    int n;
    Console.WriteLine("Please enter the number of elements for the array\n");
    n = Console.Read();
    int arr[n];
    for (int i = 0; i <= n; i++)
    {
        arr[i] = Console.Read();
    }
    int new[n], c = 0;
    for(int i=0;i<=n;i++)
    {
        if (i > 50)
        {
            new[c]= i;
        }
        c++;
    }
    Console.WriteLine("The elements greater than 50 are \n" + new{});
}
