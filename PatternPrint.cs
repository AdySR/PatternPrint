using System;

class PatternPrint
{
    static void Main(String[] args)
    {
        //Console.WriteLine("Input the depth of star");
        //int n = Convert.ToInt32(Console.ReadLine());
        ////pattern1(n);
        //roughPad(5);
        //pattern1(6);
        //pattern2();
        Pattern3();
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
    static void roughPad(int n)
    {
        for (int row = 1; row <= n; row += 1)
        {
            Console.Write("*"+"\n");
        }
    }
    
    static void pattern2()
    {
        /*
        12345
        12345
        12345
        12345
         */
    for (int i=1;i<=5;i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

    }

    static void Pattern3()
    {
        /*
        11111
        22222
        33333
        44444
        55555
        */
        for (int i = 1; i <= 5; i++)
        {
            for(int j=1;j<=5;j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}