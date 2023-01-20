using System;

namespace home_work
{
    class Program
    {
        static void Main(string[] args)
        {


            //int number = 855;
            //int sum = 0;

            //while (number != 0)
            //{
            //    sum += number % 10;
            //    number /= 10;
            //}
            //if (sum % 2 == 0)
            //{
            //    Console.WriteLine("eded cutdur");
            //}

            //else
            //{
            //    Console.WriteLine("eded tekdir");
            //}



            int number = 13;
            int sum = 0;
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;

                }          
                
            }
            
            Console.WriteLine(sum);


            //    int number = 123;
            //    int min = 9;
            //    int k;
            //    while (number > 0) 
            //    {
            //        k = number % 10;
            //        if (k < min) 
            //        {
            //            min = k;
            //        }

            //        number = number / 10; 

            //}
            //    Console.WriteLine(min);



        }
    }
}

