using System;
using System.Collections.Generic;
using System.Text;

namespace HBR__Group_Test
{
    
    class ExercisesTwo
    {
        static string stringToExit = "N";
        private static int intFirstNumber, intSecondNumber;
        private static string stringLetterOne;
        private static char charVocalone;
        
        public static void Vocal() {

            do {
                Console.Clear();
                Console.WriteLine(" Vocals ");
                Console.Write("\nInsert a Vocal: ");
                try
                {
                    stringLetterOne = Console.ReadLine();

                    if (stringLetterOne.Length ==1) {

                        charVocalone = char.Parse(stringLetterOne.ToLower());

                        if(charVocalone.Equals('a') || charVocalone.Equals('e') || charVocalone.Equals('i') || charVocalone.Equals('o') || charVocalone.Equals('u') )
                        {
                            Console.WriteLine("\n es una vocal");
                        }
                        else { 
                        
                            Console.WriteLine("\n No es una Vocal ");
                        }
                    }
                    else { 
                    
                        Console.WriteLine("More than 1 letter is not allowed");
                    }                
                }
                catch (Exception) { 
                
                    Console.WriteLine("Not allowed!");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void PositiveOrNot()
        {           
            do{
            
                Console.Clear();
                Console.WriteLine(" positive or negative ");
                Console.WriteLine("\nInsert a two number integer ");             
                Console.Write("\n 1 First Number: ");      
                
                try{
                
                    intFirstNumber= int.Parse( Console.ReadLine());

                    Console.Write("\n 2 Second number:");
                    intSecondNumber = int.Parse(Console.ReadLine());

                    if (intFirstNumber > 0 && intSecondNumber > 0)                        
                    {
                        Console.WriteLine("Los dos números son positivos");
                    }
                    else if (intFirstNumber > 0 || intSecondNumber > 0)
                    {
                        Console.WriteLine("\n Uno de los números es positivo");
                    }
                    else
                    {
                        Console.WriteLine("\n Ninguno de los números es positivo");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Try again!");
                }

                intSecondNumber = 0;
                intFirstNumber = 0;
                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));
        }

        public static void absoluteValue()
        {
            do
            {
                try
                {             
                Console.Clear();
                Console.WriteLine(" Using conditional operator ");
                Console.Write("\nInsert number: ");
                intFirstNumber = int.Parse( Console.ReadLine() );

                var mensaje = intFirstNumber > 0  ?  " "+intFirstNumber : " -"+intFirstNumber ;

                Console.WriteLine($"\n{mensaje}");
                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

                }
                catch (Exception)
                {
                    Console.WriteLine("Upps Try again!");
                }

            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void oneToTen()
        {
            do{

                try
                {
                
                int number = 0;
                Console.Clear();
                Console.Write("\n with bucle while\n ");               

                while (number<10)
                {
                    number++;
                    Console.WriteLine(number);
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

                }
                catch (Exception)
                {

                    Console.WriteLine("do not do unusual things");
                }
            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void ParNumber()
        {
            do
            {
                try
                {

                int iNumberPar = 26;
                Console.Clear();
                Console.WriteLine("\nwith bucle while \n");
             
                while (iNumberPar >= 10)
                {
                  
                    Console.WriteLine(iNumberPar);
                    iNumberPar = iNumberPar - 2;
                }
                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

                }
                catch (Exception)
                {

                    Console.WriteLine("mmmmm try again!");
                }

            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void UsingDoEhile()
        {
            do
            {
                try
                {

               
                Console.Clear();
                Console.WriteLine("\nwith bucle while \n");

                int iNumber = 0;
                do
                {
                    ++iNumber;
                    Console.WriteLine(iNumber);

                } while (iNumber < 10);

                    Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

                }
                catch (Exception)
                {
                    Console.WriteLine("let's see what happens again ");                   
                }
            } while (stringToExit.ToLower().Equals("y"));

        }
       
              public static void UsingDoEhileForPar() { 
                                                        
                do{
                try
                {            
                    Console.Clear();
                    Console.WriteLine("\nwith bucle while \n");
                    int iNumberPar = 26;

                    do{
                   
                        Console.WriteLine(iNumberPar);
                        iNumberPar = iNumberPar - 2;

                    } while (iNumberPar >= 10);

                    Console.Write("\n do you want continue? yes[y] or no[N]: ");
                    stringToExit = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(Variables.stringPAgain);
                }
                catch (Exception)
                {

                    Console.WriteLine("OW NOw try gain please");
                }

            } while (stringToExit.ToLower().Equals("y"));

              }

        public static void descount()
        {
          
            do
            {
                try
                {
                   Console.Clear();
                    Console.WriteLine("\nw15 to 5 \n");

                    for (int num = 15; num > 4; num = num - 1) Console.WriteLine(num);

                    Console.Write("\n do you want continue? yes[y] or no[N]: ");
                    stringToExit = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(Variables.stringPAgain);
                
                 }catch (Exception)
                {

                    Console.WriteLine("Layer 8 error ");
                }
            } while (stringToExit.ToLower().Equals("y"));
        }

        public static void parnumber()
        {

            do{          

                Console.Clear();
                Console.WriteLine("\n 8 par number\n");

                for (int num = 2; num < 17; num+=2) Console.WriteLine(num);         

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));

        }


        public static void Multiploofthree()
        {

            do { 
            
                Console.Clear();
                Console.WriteLine("\n multiplo of 3\n");

                for (int num = 1; num < 51; num++) Console.WriteLine($"Multiplo of 3.{num}: {3*num}");

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void Vector_number() { 
        
            int[] elements ;
            int intNumberMenus=0, intNumberMayor =0;
            int intCount=0, intNumberElement;
            do{

                Console.Clear();
                Console.WriteLine("\n vector\n");
                Console.Write("Cuantos elementos desea ingresar: ");
                try{
                
                    intNumberElement = int.Parse(Console.ReadLine());             
                     elements = new int[intNumberElement];

                    for (int i = 0; i < intNumberElement; i++)
                    {
                        Console.Write($"Insert {i+1} element: ");
                        elements[i] = int.Parse(Console.ReadLine());
                    }

                for (int i= 0; i <elements.Length ;i++)
                {
                    if (intNumberMenus == 0) intNumberMenus = elements[i];
                  
                    if (intNumberMayor < elements[i])intNumberMayor = elements[1];
                   
                    if (intNumberMenus > elements[i]) intNumberMenus = elements[i];
                 
                }
                for (int i = 0; i < elements.Length; i++)
                {
                    if (intNumberMenus.Equals(elements[i])) intCount++;                                        
                }                    

                }
                catch (Exception)
                {
                    Console.WriteLine("Upss not allowed");
                }

                Console.WriteLine($"\nNumber minus: {intNumberMenus} ");

                if (intCount > 1) Console.WriteLine($"the element {intNumberMenus} repeats {intCount} times. ");

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void VectorSalary(){       
            double[] elements = new double[5];

            do{
            
                Console.Clear();
                Console.WriteLine("\n vector 5 salary\n");
                
                try{                
                    
                    for (int i = 0; i < 5; i++){
                    
                        Console.Write($"Insert {i + 1} Salary: ");
                        elements[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                    Array.Sort(elements);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Salary: ${elements[i]}"); 
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("\nUpss not allowed");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void VectorAlphabe()
        {
            string[] elements = new string[5];

            do{
            
                Console.Clear();
                Console.WriteLine("\n vector 5 country alphabetical \n");

                try{               

                    for (int i = 0; i < 5; i++){
                    
                        Console.Write($"Insert {i + 1} country: ");
                        elements[i] = Console.ReadLine();
                    }
                    Console.WriteLine();
                    Array.Sort(elements);

                    for (int i = 0; i < 5; i++) Console.WriteLine($"Country: {elements[i]}");
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("\nUpss not allowed");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));
           
        }

        public static void VectorMatriz()
        {
            string[,] sMatriz2Da = new string[5, 2];

            do
            {
                Console.Clear();
                Console.WriteLine("Matriz");
                try
                {
                    for (int c = 0; c < 5; c++)
                    {
                        Console.WriteLine($"\nColumn {c + 1}: ");
                        for (int r = 0; r < 2; r++)
                        {
                            Console.Write($"Row {r + 1} country: ");
                            sMatriz2Da[c,r] = Console.ReadLine();
                        }
                       
                    }
                    Console.WriteLine("\n Result:");
                   // Array.Sort(sMatriz2Da);

                    for (int c = 0; c < 5; c++)
                    {
                        Console.WriteLine($"\nColumn {c + 1}: ");
                        for (int r = 0; r < 2; r++)
                        {
                            Console.WriteLine($"Row {r + 1}: {sMatriz2Da[c, r]}");
                          
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nUpss not allowed");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));
          
        }

    }
}
