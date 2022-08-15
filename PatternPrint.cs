using System;
using System.Text;

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
        //Pattern3();
        //Pattern4();
        //Pattern5();
        //Pattern6();
        //Pattern7();
        Pattern8();
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
    static void Pattern4()
    {
        //******
        //******
        //******
        //******
        //******

        for(int i =0;i<6;i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Pattern5()
    {
        /*
        A B C D E
        A B C D E
        A B C D E
        A B C D E
         */
        string a = "A";
        byte[] asciibyte = Encoding.ASCII.GetBytes(a);
        int b = char.ConvertToUtf32("A", 0);
        //Console.WriteLine(b);


        for (int i = 1; i < 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(char.ConvertFromUtf32((j + 64)) + " ");
            }
            Console.WriteLine();
        }

    }

    static void Pattern6()
    {
        //5 4 3 2 1
        //5 4 3 2 1
        //5 4 3 2 1
        //5 4 3 2 1
        //5 4 3 2 1
        for (int i=1;i<=5;i++)
        {
            for(int j=5;j>0;j--)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }

    static void Pattern7()
    {
    /*  1
        12
        123
        1234
        12345
    */
        for (int i=1;i<=5;i++)
        {
            for(int j=1;j<=i; j++)
            { Console.Write(j); }
            
            Console.WriteLine();
        }
        
    }

    public static void Pattern8()
    {
//1
//22
//333
//4444
//55555
        for (int i=1;i<=5;i++)
        {
            for(int j=1;j<=i;j++)
            { Console.Write(i); }
            Console.WriteLine();
        }
    }
}