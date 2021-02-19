using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HBR__Group_Test
{
    static class Exercises
    {
        static string stringToExit="N";
        static int intfirst, intsecond;

        public static void Numbers2()
        {
            int intNumber, intAuxiliar, intDecimal, intUnit, intLinea;
            
            do
            {
                Console.Clear();
                Console.WriteLine("INVERTION OF TWO NUMBER \n");
                Console.Write(Variables.stringMsjTwoCi);
               
                intLinea = int.Parse(Console.ReadLine());

                intNumber = intLinea;
                intDecimal = intNumber / 10;
                intUnit = intNumber % 10;
                intAuxiliar = (intUnit * 10) + intDecimal;
             
               // Console.WriteLine("INVERTION OF TWO NUMBER");
              //  Console.Write(Variables.stringMsjTwoCi);
                Console.WriteLine($"INVERTED NUMBER IS: {intAuxiliar}");
                Console.WriteLine("\ndo you want to continue yes [Y] or no [N]:");


                stringToExit = Console.ReadLine();
                intNumber = 0;
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));

        }// TODO: FIN Method NUMBER3

        public static void Numbers3(){

            int intlinea,intNum, intAux, intDec, intUni, intCen;

            do{
            
                Console.Clear();
                Console.WriteLine(Variables.stringtitle2);
                Console.Write(Variables.stringMsjThreeCi);

                intlinea = int.Parse(Console.ReadLine());

                intNum = intlinea;
                intCen = intNum / 100;
                intNum = intNum % 100;
                intDec = intNum / 10;
                intUni = intNum % 10;
                intAux = (intUni * 100) + (intDec * 10) + intCen;

                Console.Clear();
                Console.WriteLine(Variables.stringtitle2);
                Console.WriteLine($"{Variables.stringMsjThreeCi}{intlinea}\n");
                Console.WriteLine($"INVERTED NUMBER IS: {intAux}\n");
                Console.Write(" do you want to continue yes [Y] or no [N]: ");

               stringToExit = Console.ReadLine();
                intlinea = 0;
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));

        }// TODO: FIN Method NUMBER3

        public static void OperationBasic(){

            do
            {

                int intNum1, intNum2, intResul;
                Console.WriteLine(" OPERATON BASIC ");
                Console.Write("\nFIRST NUMBER: ");
                intNum1 = int.Parse(Console.ReadLine());
                Console.Write("SECOND NUMBER: ");
                intNum2 = int.Parse(Console.ReadLine());

                intResul = intNum1 + intNum2;
                Console.WriteLine("\nTHE SUM IS: {0}", intResul);

                intResul = intNum1 - intNum2;
                Console.WriteLine("THE SUBTRACTION IS: {0}-{1} = {2} ", intNum1, intNum2, intResul);

                intResul = intNum1 * intNum2;
                Console.WriteLine("THE MULTIPLICATION IS: {0}", intResul);

                intResul = intNum1 / intNum2;
                Console.WriteLine($"THE DIVISION IS: {intResul} ");

                intResul = intNum1 % intNum2;
                Console.WriteLine($"THE REMAINDER IS: {intResul}");

                Console.Write("\ndo you want continue yes [Y] or no [N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));

        }// TODO:FIN Method OperationBasic

        public static void Restaurant()
        {
            do {

                byte byteCanb, byteCanh, byteCanp;
                double doubleApagar;
                String stringlinea;
                const double constdPRECIOB = 0.8;
                const double constdPRECIOH = 2;
                const double constdPRECIOP = 1.2;

                Console.Clear();
                Console.WriteLine("   RESTAURANT");
                Console.WriteLine("     PRICES ");
                Console.WriteLine($"\nHAMBURGER: {constdPRECIOB}");
                Console.WriteLine($"POTATOES: {constdPRECIOH}");
                Console.WriteLine($"DRINKS: {constdPRECIOP}\n");

                Console.Write("AMOUNT OF HAMBURGER: ");
                stringlinea = Console.ReadLine();
                byteCanh = byte.Parse(stringlinea);

                Console.Write("AMOUNT OF POTATOES: ");
                stringlinea = Console.ReadLine();
                byteCanp = byte.Parse(stringlinea);

                Console.Write("AMOUNT OF DRINKS: ");
                stringlinea = Console.ReadLine();
                byteCanb = byte.Parse(stringlinea);

                doubleApagar = (byteCanh * constdPRECIOH) + (byteCanp * constdPRECIOP) + (byteCanb * constdPRECIOB);
                Console.WriteLine($"\nAMOUNT TO BE PAID: {doubleApagar} \n");

                Console.Write("NEW ORDER yes [Y] or no [N]:");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));

        }// TODO: END METHOD RESTAURANT

        public static void MathOperation()
        {

            do
            {
                int iNum;
                string sLine;
                long lResul;
                Console.Clear();
                Console.WriteLine("     OPERATION MATH");
                Console.Write("\n ENTER A NUMBER:  ");
                sLine= Console.ReadLine();
                iNum = int.Parse(sLine);
                lResul = Math.Abs(iNum);
                Console.WriteLine($"\nVALOR ABSOLUTO: {lResul}");
                Console.WriteLine($"POTENCIA: {Math.Pow(iNum, 3)}");
                Console.WriteLine($"RAIZ CUADRADA: {Math.Sqrt(iNum)}");
                Console.WriteLine($"SENO: {Math.Sin(iNum*Math.PI/180)}");
                Console.WriteLine($"COSENO: { Math.Cos(iNum * Math.PI / 180)}");
                Console.WriteLine($"NUMERO MAXIMO: {Math.Max(iNum ,50)}");
                Console.WriteLine($"NUMERO MIN: { Math.Min(iNum , 50)}");
                Console.WriteLine($"PARTE ENTERA: {Math.Truncate(18.78)}");
                Console.WriteLine($"REDONDEO: {Math.Round(18.78)}");

                iNum = 0;
                Console.Write("\nDo you want continue yes[N] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));

        }// TODO: END OF METHOD MATHOPERATION

        public static void Format()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("OUTPUT FORMATS\n\n");

                double dBase, dAltura, dResult;
                string slinea;

                Console.Write("DIGITE LA BASE: ");
                slinea = Console.ReadLine();
                dBase = double.Parse(slinea);

                Console.Write("DIGITE LA ALTURA: ");
                slinea = Console.ReadLine();
                dAltura = double.Parse(slinea);

                dResult = (dBase * dAltura) / 2;

                Console.WriteLine($"AREA TRAINGULO: {string.Format("{0:###.00}",dResult)}" );
                Console.WriteLine($"AREA TRIANGULO: {string.Format("{0:c}",dResult)}");
                Console.WriteLine($"AREA TRIANGULO: {string.Format("{0:f}", dResult)}");
                Console.WriteLine($"AREA TRIANGULO: {string.Format("{0:g}", dResult)} \n");

                Console.WriteLine($"HOY ES: {string.Format("{0:F}", DateTime.Now)}");
                Console.WriteLine($"HOY ES: {string.Format("{0:dddd} {0:dd/MM/yy}", DateTime.Now)}");

               
                Console.Write("\n\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));

        }// TODO: END OF METHOD FORMAT

        public static void PExercise()
        {
            do
            {
                int iNum1, iNum2;
                string sLine;
                double dResul;
                Console.WriteLine("PROPOSED EXERCISE\n");

                Console.Write("NUMBER 1: ");
                sLine = Console.ReadLine();
                iNum1 =int.Parse(sLine);

                Console.Write("NUMBER 2: ");
                sLine = Console.ReadLine();
                iNum2 = int.Parse(sLine);

                dResul = (iNum1 + iNum2) * (iNum1 - iNum2);

                Console.WriteLine($"\n RESULT: {dResul}");
                
                Console.Write("\n\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));
        }// TODO: END OF METHOD PExercise

        public static void Biggernumber()
        {

            List<int> ListNumber = new List<int>() { 1,2,3};

            do
            {
                
                Console.Clear();
                Console.WriteLine("BiGGER NUMBER");
                Console.Write("AMONG HOW MANY NUMBERS DO YOU WANT TO COMPARE WHICH IS THE GREATEST?: ");
                int iquantity = 1 + int.Parse(Console.ReadLine());
                Console.WriteLine();
                

                for(int i=1; i< iquantity; i++)
                {
                    Console.Write($"NUMBER{i}: ");

                    int dNumber = int.Parse(Console.ReadLine());

                    ListNumber.Add(dNumber);

                }

                ListNumber.Sort();
                int dMaxValue = ListNumber.Max();

                Console.WriteLine($"\nMAX VALUE IS: {dMaxValue} \n");

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));
        }

        // EL USUARIO TECLEARA DOS NUMEROA
        public static void UserDivition()
        {
            double dfirstNumber, dSecondNumber, dResult;

            do
            {
                Console.Clear();
                Console.WriteLine("Division and Rest\n");

                try
                {
                    Console.Write("Insert 1 First number:");
                    dfirstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Insert 2 Second number:");
                    dSecondNumber = double.Parse(Console.ReadLine());

                    dResult = dfirstNumber / dSecondNumber;
                    Console.WriteLine($"\nTHE DIVISION IS: {dResult} ");

                    dResult = dfirstNumber % dSecondNumber;
                    Console.WriteLine($"THE REMAINDER IS: {dResult}");
                }
                catch (Exception)
                {

                    Console.WriteLine("\nInsert numbers not other format");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));

        }// End of tecleara 9

        public static void multipleofNumbers()
        {
            int intfirstNumber, intSecondNumber;

            do
            {

                Console.Clear();
                Console.WriteLine("Multiple Of two numbers");

                try
                {
                    Console.Write("\n1 Insert the multiple to check number:");
                    intfirstNumber = int.Parse(Console.ReadLine());

                    Console.Write("2 Insert number master number:");
                    intSecondNumber = int.Parse(Console.ReadLine());

                    if(intfirstNumber % intSecondNumber == 0)
                    {
                        Console.WriteLine($"\nThe number {intfirstNumber} is multiple of { intSecondNumber}");
                        
                    }
                    else
                    {
                        Console.WriteLine($" The number {intfirstNumber} is not multiple of { intSecondNumber}");
                        intfirstNumber = 0;
                        intSecondNumber = 0;
                    }
 
                }
                catch (Exception)
                {
                    Console.WriteLine("Insert integer only ");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while(stringToExit.ToLower().Equals("y"));

        }
       

        public static void multiplicationadverta(){
                         
            do{
            
                Console.Clear();
                Console.WriteLine("Multiplication 2");
                try{
                
                    Console.Write("\nInsert 1 First number: ");               
                    intfirst = int.Parse(Console.ReadLine());
                    try{
                                          

                        if(intfirst == 0)
                        {
                            Console.WriteLine("El producto de 0 por cualquier número es 0");
                        }else
                        {
                            Console.Write("Insert 2 Second number: ");
                            intsecond = int.Parse(Console.ReadLine());

                            Console.WriteLine($"\nProduct between: {intfirst} and {intsecond} = {intfirst * intsecond}");
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Upss Only integer");
                    }
                }
                catch (Exception)
                { 
                    Console.WriteLine("Insert integer only ");
                }
                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));

        }

        public static void vidition2()
        {        
            do
            {
                Console.Clear();
                Console.Write("\nInsert first number: ");
                try
                {
                    intfirst = int.Parse(Console.ReadLine());

                    try
                    {
                        intsecond = int.Parse(Console.ReadLine());

                        if (intsecond == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero");
                        }
                        else
                        {
                            Console.WriteLine($"Result {intfirst* intsecond}");
                        }                       
                    }
                    catch (Exception) { 
                                           
                        Console.WriteLine("Not Allowed");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Not Allowed");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);

            } while (stringToExit.ToLower().Equals("y"));
        }
    }
}