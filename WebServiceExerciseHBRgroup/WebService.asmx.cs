using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceExerciseHBRgroup.Models;

namespace WebServiceExerciseHBRgroup{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   
    public class WebService : System.Web.Services.WebService{    

        [WebMethod(Description = "Response in XML Invert two numbers position")]
        public int Numbers2(int intLinea){
        
            int intNumber, intAuxiliar, intDecimal, intUnit;

            intNumber = intLinea;
            intDecimal = intNumber / 10;
            intUnit = intNumber % 10;
            intAuxiliar = (intUnit * 10) + intDecimal;

            return intAuxiliar;
        }

        [WebMethod(Description = "Response in XML Invert three numbers position")]
        public int Numbers3(int intlinea){
        
            int intNum, intAux, intDec, intUni, intCen;

            intNum = intlinea;
            intCen = intNum / 100;
            intNum = intNum % 100;
            intDec = intNum / 10;
            intUni = intNum % 10;
            intAux = (intUni * 100) + (intDec * 10) + intCen;

            return intAux;
        }

        [WebMethod(Description = "Response in XML Operation Basic + - * / two numbers position")]
        public List<int> OperationBasic(int NumberFirst, int NumberSecond){
        
            List<int> myList = new List<int>();

            int sum = NumberFirst + NumberSecond;
            myList.Add(sum);

            int substract = NumberFirst - NumberSecond;
            myList.Add(substract);

            int multiplay = NumberFirst * NumberSecond;
            myList.Add(multiplay);

            int divide = NumberFirst / NumberSecond;
            if (NumberSecond == 0) { divide = -1; }
            myList.Add(divide);

            return myList;
        }

        [WebMethod(Description = "Response in JSON - Restaurant")]
        public string Restaurant(double AMOUNT_OF_HAMBURGER, double AMOUNT_OF_POTATOES, double AMOUNT_OF_DRINKS){
        
            List<MenuPickUp> myList = new List<MenuPickUp>();
            const double constdPRECIOB = 0.8;
            const double constdPRECIOH = 2;
            const double constdPRECIOP = 1.2;

            MenuPickUp item1 = new MenuPickUp() { opction = "HAMBURGER", amount = AMOUNT_OF_HAMBURGER * constdPRECIOH };
            myList.Add(item1);
            myList.Add(new MenuPickUp() { opction = "POTATOES", amount = AMOUNT_OF_POTATOES * constdPRECIOP });
            myList.Add(new MenuPickUp() { opction = "DRINKS", amount = AMOUNT_OF_DRINKS * constdPRECIOB });
            myList.Add(new MenuPickUp() { opction = "Total:", amount = AMOUNT_OF_HAMBURGER * constdPRECIOH + AMOUNT_OF_POTATOES * constdPRECIOP + AMOUNT_OF_DRINKS * constdPRECIOB });

            return JsonConvert.SerializeObject(myList, Newtonsoft.Json.Formatting.Indented);
        }

        [WebMethod(Description = "Response in XML - Operations class Math")]
        public List<MathOperationModel> MathOperations(int NUMBER_ENTER){
        
            List<MathOperationModel> myListOperation = new List<MathOperationModel>();
            int iNum = NUMBER_ENTER;

            myListOperation.Add(new MathOperationModel() { Operation = $"\nVALOR ABSOLUTO: {Math.Abs(iNum)}", Value = Math.Abs(iNum) });
            myListOperation.Add(new MathOperationModel() { Operation = $"POTENCIA:", Value = Math.Pow(iNum, 3) });
            myListOperation.Add(new MathOperationModel() { Operation = $"RAIZ CUADRADA: ", Value = Math.Sqrt(iNum) });
            myListOperation.Add(new MathOperationModel() { Operation = $"SENO:", Value = Math.Sin(iNum * Math.PI / 180) });
            myListOperation.Add(new MathOperationModel() { Operation = $"COSENO:", Value = Math.Cos(iNum * Math.PI / 180) });
            myListOperation.Add(new MathOperationModel() { Operation = $"NUMERO MAXIMO:", Value = Math.Max(iNum, 50) });
            myListOperation.Add(new MathOperationModel() { Operation = $"NUMERO MIN:", Value = Math.Min(iNum, 50) });
            myListOperation.Add(new MathOperationModel() { Operation = $"PARTE ENTERA:", Value = Math.Truncate(18.78) });
            myListOperation.Add(new MathOperationModel() { Operation = $"REDONDEO:", Value = Math.Round(18.78) });

            return myListOperation;
        }

        [WebMethod(Description = "Response in XML - Formats ")]
        public string[] DateFormats(double DIGITE_LA_BASE, double DIGITE_LA_ALTURA){       

            double dResult = (DIGITE_LA_BASE * DIGITE_LA_ALTURA) / 2;
            string[] sResultToReturn = new string[6];

            sResultToReturn[0] = $"AREA TRAINGULO: {string.Format("{0:###.00}", dResult)}";
            sResultToReturn[1] = $"AREA TRIANGULO: {string.Format("{0:c}", dResult)}";
            sResultToReturn[2] = $"AREA TRIANGULO: {string.Format("{0:f}", dResult)}";
            sResultToReturn[3] = $"AREA TRIANGULO: {string.Format("{0:g}", dResult)}";
            sResultToReturn[4] = $"HOY ES: {string.Format("{0:F}", DateTime.Now)}";
            sResultToReturn[5] = $"HOY ES: {string.Format("{0:dddd} {0:dd/MM/yy}", DateTime.Now)}";

            return sResultToReturn;
        }

        [WebMethod(Description = "Response in JSON - Proposed Excercise")]
        public string ProposedExcercise(int intNumber1, int intNumber2){        

            double dResul = (intNumber1 + intNumber2) * (intNumber1 - intNumber2);

            return JsonConvert.SerializeObject($"RESULT: {dResul}", Newtonsoft.Json.Formatting.Indented);
        }

        [WebMethod(Description = "NO TERMINADO AUNNNNNN")] //NO TERMINADO AUNN
        public string BiggerNumber(int HowManyNumberToCompare){        

            List<int> ListNumber = new List<int>() { 1, 2, 3 };

            int iquantity = 1 + HowManyNumberToCompare;

            for (int i = 1; i < iquantity; i++){  }
                      
            ListNumber.Sort();

            int dMaxValue = ListNumber.Max();
            return $"\nMAX VALUE IS: {dMaxValue}";
        }

        [WebMethod(Description = "Response in JSON - The user will insert two numbers")]
        public string UserDivition(double dfirstNumber, double dSecondNumber){        

            string[] dResult = new string[3];

            dResult[0] = $"\nTHE DIVISION IS: {dfirstNumber / dSecondNumber}";
            dResult[1] = $"THE REMAINDER IS: {dfirstNumber % dSecondNumber}";

            return JsonConvert.SerializeObject(dResult, Newtonsoft.Json.Formatting.Indented);
        }

        [WebMethod(Description = "Response in JSON - Multiple of Two numbers")]
        public string MultipleOfNumbers(int multipleNumber, int masterNumber){
        
            string[] sArrayResult = new string[2];

            if (multipleNumber % masterNumber == 0){
            
                sArrayResult[0] = $"The number {multipleNumber} is multiple of { masterNumber}";
            }
            else{ sArrayResult[1] = $" The number {multipleNumber} is not multiple of { masterNumber}"; }
                                      
            return JsonConvert.SerializeObject(sArrayResult, Newtonsoft.Json.Formatting.Indented);
        }

        [WebMethod(Description = "Response in JSON With =Try Catch= MultiplicationAdverta")]
        public string MultiplicationAdverta(int First_number, int Second_number){
        
            string sResult;
            try{
            
                if (First_number == 0) sResult = "El producto de 0 por cualquier número es 0";

                else sResult = $"Product between: {First_number} and {Second_number} = {First_number * Second_number}";

            }catch (Exception) { sResult = "Upss ly integer"; }           

            return sResult;
        }

        [WebMethod(Description = "Response in XML - Divition 2")]
        public string divition(int First_Number, int Second_Number){        

            string Error = "Not Allowed";

            try{            

                if (Second_Number == 0) return "Error: No se puede dividir entre cero";

                else return $"Result {First_Number * Second_Number}";

            }catch (Exception) { return Error; }            

        }

        [WebMethod(Description = "Response in JSON - Vocals")]
        public string Vocal(string Letter_One){
        
            char charVocalone;

            try{
            
                if (Letter_One.Length == 1){                

                    charVocalone = char.Parse(Letter_One.ToLower());

                    if (charVocalone.Equals('a') || charVocalone.Equals('e') || charVocalone.Equals('i') || charVocalone.Equals('o') || charVocalone.Equals('u')){
                    
                        return "its is a vocal";

                    }else { return "its not a Vocal "; }
                    
                }else { return "More than 1 letter is not allowed"; }
                
            }catch (Exception){ return "Not allowed!"; }
                         
        }

        [WebMethod(Description = "Response in XML - Positive or Not")]
        public String PositiveOrNot(int FirstNumber, int SecondNumber){       

            try{
            
                if (FirstNumber > 0 && SecondNumber > 0) return "Los dos números son positivos";

                else if (FirstNumber > 0 || SecondNumber > 0) return "Uno de los números es positivo";

                else return "Ninguno de los números es positivo";

            }catch (Exception){  return "Try again!"; }        
                     
        }

        [WebMethod(Description = " Response in XML Absolute Value")]
        public string absoluteValue(int FirstNumber){
        
            try { return FirstNumber > 0 ? " " + FirstNumber : " -" + FirstNumber; }

            catch (Exception) { return "Upps Try again!"; }

        }

        [WebMethod(Description = "Response in JSON - Bucle while")]
        public string OneToTen() {         

            int number = 0;
            int[] ArrayIntResult = new int[10];

            while (number < 10){            

                ArrayIntResult[number] = number++;

            }return JsonConvert.SerializeObject(ArrayIntResult, Newtonsoft.Json.Formatting.Indented);
            
        }

        [WebMethod(Description = "Reponse in JSON - with bucle while ParNumber")]
        public String ParNumber(){
        
            List<int> myList = new List<int>();

            int iNumberPar = 26;

            while (iNumberPar >= 10){            
                iNumberPar = iNumberPar - 2;
                myList.Add(iNumberPar);
            } return JsonConvert.SerializeObject(myList, Newtonsoft.Json.Formatting.Indented);
           
        }

        [WebMethod(Description = "Response in JSON - with bucle do while")]
        public string UsingDoEhile(){
        
            List<int> myListDo = new List<int>();
            int iNumber = 0;

            do{            
                ++iNumber;
                myListDo.Add(iNumber);

            } while (iNumber < 10);

            return JsonConvert.SerializeObject(myListDo, Newtonsoft.Json.Formatting.Indented);
        }

        [WebMethod(Description = "Response in JSON - with bucle while")]
        public string UsingDoEhileForPar(){        

            List<int> myListDo = new List<int>();
            int iNumberPar = 26;
            do{
            
                iNumberPar = iNumberPar - 2;
                myListDo.Add(iNumberPar);
            } while (iNumberPar >= 10);

            return JsonConvert.SerializeObject(myListDo, Newtonsoft.Json.Formatting.Indented);
        }

        [WebMethod(Description = "Response in JSON -  descount 15 to 5")]
        public string descount(){        

            int[] intArrayResult = new int[11];

            for (int num = 15; num > 4; num = num - 1) { intArrayResult[num] = num; }

            return JsonConvert.SerializeObject(intArrayResult, Newtonsoft.Json.Formatting.Indented);

        }

        [WebMethod(Description = "Response in XML - 8 par number")]
        public List<int> parNumber8(){
        
            List<int> intArrayResult = new List<int>();

            for (int num = 2; num < 17; num += 2) { intArrayResult.Add(num); }

            return intArrayResult;
        }

        [WebMethod(Description = "Response in XML - Multiploofthree ")]
        public List<string> Multiploofthree(){        

            List<string> myArrayList = new List<string>();

            for (int num = 1; num < 51; num++){
           
                myArrayList.Add($"Multiplo of 3.{num}: {3 * num}");
            }
            return myArrayList;
        }

        [WebMethod(Description = "Response in XML - vector")]
        public string Vector_number(int NumberElement) {

            int[] elements;
            int intNumberMenus = 0, intNumberMayor = 0, intCount = 0;

            try {

                elements = new int[NumberElement];

                for (int i = 0; i < NumberElement; i++) {

                    Console.Write($"Insert {i + 1} element: ");
                    elements[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < elements.Length; i++) {

                    if (intNumberMenus == 0) intNumberMenus = elements[i];

                    if (intNumberMayor < elements[i]) intNumberMayor = elements[1];

                    if (intNumberMenus > elements[i]) intNumberMenus = elements[i];
                }
                for (int i = 0; i < elements.Length; i++) {  if (intNumberMenus.Equals(elements[i])) intCount++; }
                                   
            }
            catch (Exception) { return "Upss not allowed"; }

            if (intCount > 1) return $"the element {intNumberMenus} repeats {intCount} times. ";

            return $"\nNumber minus: {intNumberMenus} ";

        }

        [WebMethod(Description = " Response in XML - vector 5 salary ")]
        public double[] VectorAlphabe(){

            double[] elements = new double[5];

                try{
                
                    for (int i = 0; i < 5; i++){                    

                        Console.Write($"Insert {i + 1} Salary: ");
                        elements[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                    Array.Sort(elements);

                 for (int i = 0; i < 5; i++){ Console.WriteLine($"Salary: ${elements[i]}");   }

                 return elements;
                
                 }catch (Exception e){
                
                Console.WriteLine(e.StackTrace);
                return elements;
                }
        }

        [WebMethod(Description = "Response in JSON - Matriz")]
        public string VectorMatriz(){

            List<string> myList = new List<string>();
            string[,] sMatriz2Da = new string[5, 2];

                try{
                
                    for (int c = 0; c < 5; c++){
                    
                        Console.WriteLine($"\nColumn {c + 1}: ");
                        for (int r = 0; r < 2; r++){
                        
                            Console.Write($"Row {r + 1} country: ");
                            sMatriz2Da[c, r] = Console.ReadLine();
                        }
                    }
                    Console.WriteLine("\n Result:");

                    for (int c = 0; c < 5; c++){
                    
                        Console.WriteLine($"\nColumn {c + 1}: ");
                        for (int r = 0; r < 2; r++){
                        
                            Console.WriteLine($"Row {r + 1}: {sMatriz2Da[c, r]}");
                            myList.Add($"Row {r + 1}: {sMatriz2Da[c, r]}");
                        }

                    }return JsonConvert.SerializeObject(myList, Newtonsoft.Json.Formatting.Indented);
                                        
                  }catch (Exception){
                               
                  Console.WriteLine("\nUpss not allowed");
                  return JsonConvert.SerializeObject("Error", Newtonsoft.Json.Formatting.Indented);
                }
        }

        [WebMethod(Description = "Responde in JSON - Contry temperature ")]
        public string countriesTemperature(){
        
            string[] Countrys = new string[4];
            int[,] svTemperature = new int[4,3];
            int[] tempetureTri = new int[4];
            int intsum = 0, higher;
            string stringCountry = "";

                try{
                                   
                    for (int c = 0; c < 4; c++){  //prompts the user for the country and temperatures and saves them 
                    
                        Console.Write($"Insert country name: ");
                        Countrys[c] = (Console.ReadLine());

                        for (int t = 0; t < svTemperature.GetLength(1); t++){
                        
                            Console.Write($"Insert Month tempeture: ");
                            svTemperature[c, t] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();
                    }
                    
                    for (int cp = 0; cp < Countrys.Length; cp++){  //Print monthly temperature
                    
                        Console.Write($"Country: {Countrys[cp]}  tempeture:");

                        for (int tp = 0; tp < svTemperature.GetLength(1); tp++){
                        
                            Console.Write($" {svTemperature[cp, tp]} ");
                        }
                        Console.WriteLine("");
                    }
                    
                    for (int tt = 0; tt < svTemperature.GetLength(0); tt++){//Calculate quarterly temperature 

                        for (int cc = 0; cc < svTemperature.GetLength(1); cc++){
                        
                            intsum = intsum + svTemperature[tt, cc];
                        }
                        tempetureTri[tt] = intsum / 3;
                    }
                    Console.WriteLine("");
                     
                    for (int ct = 0; ct < Countrys.Length; ct++){//Print quarterly temperature
                    
                        Console.WriteLine($"{Countrys[ct]} {tempetureTri[ct]}");
                    }

                    higher = tempetureTri[0]; stringCountry = Countrys[0];
                    
                    for (int r = 0; r < Countrys.Length; r++){//Print Higher temperature 
                    
                        if (tempetureTri[r] > higher){
                        
                            higher = tempetureTri[r];
                            stringCountry = Countrys[r];
                        }
                    }return JsonConvert.SerializeObject($"country with the highest quarterly temperature {stringCountry} --- temperature: {higher}",Newtonsoft.Json.Formatting.Indented);
                    
                } catch (Exception){ return JsonConvert.SerializeObject("Upss not allowed", Newtonsoft.Json.Formatting.Indented); }                                                             
        }
    }
}
