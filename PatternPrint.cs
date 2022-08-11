using System;

class PatternPrint
{
    static void Main(String[] args)
    {
        Console.WriteLine("Input the depth of star");
        int n = Convert.ToInt32(Console.ReadLine());
        pattern1(n);
    }

    static void pattern1(int n)
        //*
        //**
        //***
        //****
        //*****
        //******
    {
        for (int row=1; row<=n; row+=1)
        {
            for(int col=1; col<=row; col++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

        }
    }
}