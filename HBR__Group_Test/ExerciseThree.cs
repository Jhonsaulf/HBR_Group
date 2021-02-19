using System;
using System.Collections.Generic;
using System.Text;

namespace HBR__Group_Test
{
    class ExerciseThree
    {
        static string stringToExit = "N";

        public static void countriesTemperature()
        {
            string[] Countrys = new string[4];
            int[,] svTemperature = new int[4, 3];
            int[] tempetureTri = new int[4];
            int intsum = 0, higher;
            string stringCountry = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Contry temperature");
                try
                {
                    //prompts the user for the country and temperatures and saves them 
                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write($"Insert country name: ");
                        Countrys[c] = (Console.ReadLine());

                        for (int t = 0; t < svTemperature.GetLength(1); t++)
                        {
                            Console.Write($"Insert Month tempeture: ");
                            svTemperature[c, t] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();
                    }

                    //Print monthly temperature 
                    for (int cp = 0; cp < Countrys.Length; cp++)
                    {
                        Console.Write($"Country: {Countrys[cp]}  tempeture:");

                        for (int tp = 0; tp < svTemperature.GetLength(1); tp++)
                        {
                            Console.Write($" {svTemperature[cp, tp]} ");
                        }
                        Console.WriteLine("");
                    }

                    //Calculate quarterly temperature 
                    for (int tt = 0; tt < svTemperature.GetLength(0); tt++)
                    {
                        intsum = 0;
                        for (int cc = 0; cc < svTemperature.GetLength(1); cc++) {
                            intsum = intsum + svTemperature[tt, cc];
                        }
                        tempetureTri[tt] = intsum / 3;
                    }
                    Console.WriteLine("");
                    //Print quarterly temperature 
                    for (int ct = 0; ct < Countrys.Length; ct++)
                    {
                        Console.WriteLine($"{Countrys[ct]} {tempetureTri[ct]}");
                    }

                    //Print Higher temperature 
                    higher = tempetureTri[0];
                    stringCountry = Countrys[0];
                    for (int r = 0; r < Countrys.Length; r++)
                    {
                        if (tempetureTri[r] > higher)
                        {
                            higher = tempetureTri[r];
                            stringCountry = Countrys[r];
                        }
                    }

                    Console.WriteLine($"country with the highest quarterly temperature {stringCountry} --- temperature: {higher}");
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

        public static void DiasFaltasEmpleado()
        {
            string[] svNameEmploye = new string[3];
            int[][] imDayOff;
            int intDays;
            string stringEmpMostDayOff;
            do
            {
                Console.Clear();
                try
                {
                    imDayOff= new int[3][];
                    Console.WriteLine("Days that have been missing");

                    //request user and missing days 
                    for (int r = 0; r < svNameEmploye.Length; r++)
                    {
                        Console.Write("\ninsert employee name: ");
                        svNameEmploye[r] = Console.ReadLine();

                        Console.Write($"\nHow many days has {svNameEmploye[r]} been missing?:");
                        intDays = int.Parse(Console.ReadLine());
                        imDayOff[r] = new int[intDays];

                        for (int c = 0; c < imDayOff[r].Length; c++)
                        {
                            Console.Write("Insert day number: ");
                            imDayOff[r][c] = int.Parse(Console.ReadLine());
                        }
                    }

                    // print day missing
                    for (int i = 0; i < svNameEmploye.Length; i++)
                    {
                        Console.WriteLine($"{svNameEmploye[i]} missed {imDayOff[i].Length} days."  );
                    }

                    Console.WriteLine();
                    intDays = imDayOff[0].Length;
                    stringEmpMostDayOff = svNameEmploye[0];

                    //check who missed less 
                    for (int rr = 0; rr < imDayOff.Length; rr++)
                    {
                        if (imDayOff[rr].Length < intDays)
                        {
                            stringEmpMostDayOff = svNameEmploye[rr];
                            intDays = imDayOff[rr].Length;
                        }
                    }

                    Console.WriteLine($"the employee {stringEmpMostDayOff} missed less ( days:{intDays})");
                }
                catch (Exception)
                {
                    Console.WriteLine("upss try again");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));
        }

        public static void RowToRow()
        {
            int[,] intMat;
            int intRow, intColumn;
            do
            {
                try
                {

             
                Console.Clear();

                Console.WriteLine("exchange of rows ");

                Console.Write("How many Rows: ");
                intRow = int.Parse(Console.ReadLine());

                Console.Write("How many Columns: ");
                intColumn = int.Parse(Console.ReadLine());

                //Fill of element 
                intMat = new int[intRow,intColumn];
                Console.WriteLine();
                for (int r = 0; r < intMat.GetLength(0); r++)
                {
                    for (int cc = 0; cc < intMat.GetLength(1); cc++)
                    {
                        Console.Write("\nInsert Element: ");
                        intMat[r,cc]= int.Parse(Console.ReadLine());
                    }
                }

                //Print bfore change
                for (int rr = 0; rr < intMat.GetLength(0); rr++)
                {
                    for (int cc = 0; cc < intMat.GetLength(1); cc++)
                    {
                        Console.Write($"{intMat[rr, cc]} ");
                    }
                    Console.WriteLine();
                }

                //change Row
                for (int rc = 0; rc < intMat.GetLength(1); rc++)
                {
                    int intAux = intMat[0, rc];
                    intMat[0, rc] = intMat[1, rc];
                    intMat[1,rc] = intAux;
                }

                //Print
                for (int rr = 0; rr < intMat.GetLength(0); rr++)
                {
                    for (int cc = 0; cc < intMat.GetLength(1); cc++)
                    {
                        Console.Write($"{intMat[rr,cc]} ");                        
                    }
                    Console.WriteLine();
                }

                }
                catch (Exception)
                {
                    Console.WriteLine("something unexpected has happened try again!");
                }

                Console.Write("\n do you want continue? yes[y] or no[N]: ");
                stringToExit = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(Variables.stringPAgain);
            } while (stringToExit.ToLower().Equals("y"));
        }
    }
}
