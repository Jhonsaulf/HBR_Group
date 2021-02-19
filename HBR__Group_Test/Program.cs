using System;

namespace HBR__Group_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortOpcion=0;

            

            do
            {
                Console.Clear();
                Console.Write(Variables.stringMENU);             

                try
                {

                    shortOpcion = short.Parse(Console.ReadLine());
               
                    Console.Clear();
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {

                    Console.WriteLine(Variables.stringOutOfRange);

                }
                catch (FormatException)
                {
                    Console.WriteLine(Variables.stringFORMATEXCEPTION);
                }

                switch (shortOpcion)
                {
                    case 1:
                        Exercises.Numbers2();

                        break;
                    case 2:
                        Exercises.Numbers3();
                        break;
                    case 3:
                        Exercises.OperationBasic();
                        break;
                    case 4:
                        Exercises.Restaurant();
                        break;
                    case 5:
                        Exercises.MathOperation();
                        break;
                    case 6:
                        Exercises.Format();
                        break;
                    case 7:
                        Exercises.PExercise();
                        break;
                    case 8:
                        Exercises.Biggernumber();
                        break;
                    case 9:
                        Exercises.UserDivition();
                        break;
                    case 10:
                        Exercises.multipleofNumbers();
                        break;
                    case 11:
                        Exercises.multiplicationadverta();
                        break;
                    case 12:
                        Exercises.vidition2(); 
                        break;
                    case 13:
                        ExercisesTwo.Vocal(); 
                        break;
                    case 14:
                        ExercisesTwo.PositiveOrNot();
                        break;
                    case 15:
                        ExercisesTwo.absoluteValue();
                        break;
                    case 16:
                        ExercisesTwo.oneToTen();
                        break;
                    case 17:
                        ExercisesTwo.ParNumber();
                        break;
                    case 18:
                        ExercisesTwo.UsingDoEhile();
                        break;
                    case 19:
                        ExercisesTwo.UsingDoEhileForPar();
                        break;
                    case 20:
                        ExercisesTwo.descount(); 
                        break;
                    case 21:
                        ExercisesTwo.parnumber(); 
                        break;
                    case 22:
                        ExercisesTwo.Multiploofthree(); 
                        break;
                    case 23:
                        ExercisesTwo.Vector_number(); 
                        break;
                    case 24:
                        ExercisesTwo.VectorSalary();
                        break;
                    case 25:
                        ExercisesTwo.VectorAlphabe();
                        break;
                    case 26:
                        ExercisesTwo.VectorMatriz();
                        break;
                    case 27:
                        ExerciseThree.countriesTemperature();
                        break;
                    case 28:
                        MatrizIrregular.IrregularMatrices();
                        break;
                    case 29:
                        ExerciseThree.DiasFaltasEmpleado();
                        break;
                    case 30:
                        ExerciseThree.RowToRow();
                        break;
                       
                    case 0:

                        break;
                    default:

                        Console.WriteLine(Variables.stringOutOfRange);
                        shortOpcion = 0;
                        break;

                }


                shortOpcion = 0;
            } while (Console.ReadKey().Key != ConsoleKey.D0);

        }

    }
}
