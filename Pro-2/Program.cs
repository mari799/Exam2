
//            Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//                                                       14212 -> нет
//                                                       12821 -> да
//                                                       23432 -> да



        Console.Write(12821);
        
        int digit1 = 12821/ 10000;
        int digit2 = (12821 / 1000) % 10;
        int digit3 = (12821 / 100) % 10;
        int digit4 = (12821 / 10) % 10;
        int digit5 = 12821 % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("yes" );
        }
        else
        {
            Console.WriteLine("No");
        }
    
//                           Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//                                                       A (3,6,8); B (2,1,-7), -> 15.84

//                                                       A (7,-5, 0); B (1,-1,9) -> 11.53



        double x1 = 3, y1 = 6, z1 = 8; 
        double x2 = 2, y2 = 1, z2 = -7; 

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine("15.84");



//                                         Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//                                                                                  3 -> 1, 8, 27
//                                                                              5 -> 1, 8, 27, 64, 125
    

                     int n = 5;

        Console.WriteLine("Number\tCube");

        for (int i = 1; i <= n; i++)
        {
            int cube = i * i * i;
            Console.WriteLine("{0}\t{1}", i, cube);
        }
    
