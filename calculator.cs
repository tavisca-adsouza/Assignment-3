using System;
using System.Collections;
using System.Linq;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;
            char start =  '\0';
            //System.Console.WriteLine(SendKeyPress(start));
            while(true){
            input = Convert.ToChar(Console.ReadLine());
            if(input == '=')
                break;
            //string output = SendKeyPress(input);
           // System.Console.WriteLine("The output is:");
          //  System.Console.WriteLine(output);

            }
        }
        public static string equation;
        public static int count;
        Program(){
            equation = "";
            count = 0;
        }
        public static string SendKeyPress(char input)
        {
            count = count + 1;
            // check to see if the input is valid or not
            char[] operators = {'+', '-', '/', 'x','=', 'X'};
            char start = '\0';
            bool isADigit = Char.IsDigit(input);
            bool isAnOperator = operators.Contains(input);
            bool isReset = (input == 'C' || input == 'c');
            /*
            if(input == start || isReset){
                equation = "";
                count = 0;
                return "0";
            }*/
            //add to the string
            /* 
            if(isADigit || isAnOperator){
                equation = equation + input;
                System.Console.WriteLine("Uptill now the string is: {0} and the index is {1} and count is {2}", equation, count-1, count);
            }
            else{
                equation = "";
                count = 0;
                return "-E-";
            }

            if(count == 3){
                int index = count - 1;
                if(equation.Length != 3){
                    System.Console.WriteLine("Something went wrong equation is not correct length.");
                    throw new InvalidCastException();
                }
                else{
                    //bool isAnOperator = operators.Contains(equation[1]);
                    if(operators.Contains(equation[1])){
                        double variable1 = Convert.ToDouble(equation[0]);
                        double variable2 = Convert.ToDouble(equation[2]);
                        char operatr = equation[1];
                        double result = 0.0;
                        if(operatr == '+'){
                            result = variable1 + variable2;
                            return Convert.ToString(result);
                        }

                    }
                    else{
                        System.Console.WriteLine("Something is wrong with the equation and middle of the string is not an operator.");
                        throw new InvalidCastException();
                    }
                }
            }
            */

            if(isADigit){
                System.Console.WriteLine("This a number!");
                //myStack.Push(key);
            }
            else if(isAnOperator)
            {
                System.Console.WriteLine("This is an arithmetic operator!");
                //myStack.Push(key);
            }
            else{
                //myStack.Push(key);
                System.Console.WriteLine("Could not recognise what {0} is", input);
            }
            
            return Convert.ToString(input);
            //input;
            //else ifo(Char.IsDigit(key) and )
            //throw new NotImplementedException();
        }
    }
}
