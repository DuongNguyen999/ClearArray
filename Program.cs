﻿
internal class Program
{
    private static void Main(string[] args)
    {
       int[] myArray={1,2,3,4,5,6,7,8,9,10,11};
       Console.WriteLine("Nhap gia tri xoa");
       int x = Convert.ToInt32(Console.ReadLine());
       ClearArray(x,myArray);
    }
    private static void ClearArray(int x, int[] myArray)
    {
        int indext = 0;
       //tim phan tu da nhap co trong mang
       for (int i = 0; i < myArray.Length; i++)
       {
        if(myArray[i] == x)
        {
           indext=i;
        }
       }
       //chen phan tu da nhap tai vi tri index
       for (int i = indext; i < myArray.Length-1; i++)
       {
        myArray[i] = myArray[i+1];
       }
       //thay doi kich thuoc mang
       Array.Resize(ref myArray, myArray.Length-1);
       for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i]+",");
        }
    }
    
}