// mustafa gamal mohammed 

    

        
        int a, b, i, j, flag;

        Console.Write("\n\n");
        Console.Write("Find prime numbers within a given number of range:\n");
        Console.Write("------------------------------------------------------");
        Console.Write("\n\n");

        Console.WriteLine("enter n1 range ");
                        

        
        a = int.Parse(Console.ReadLine());


        Console.WriteLine("enter n2 range : ");
                        

        b = int.Parse(Console.ReadLine());

        
        Console.WriteLine("\nPrime numbers between " +
                        "{0} and {1} are: ", a, b);

       
        for (i = a; i <= b; i++)
        {

           
            if (i == 1 || i == 0)
                continue;

            flag = 1;

            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }

            
            if (flag == 1)
                Console.WriteLine(i);
        }
    


