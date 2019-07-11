using System;

namespace GradeBook
{
    class Program
    {
        public static int calculateScore(int[,] fields){
            int score = 0;
            //bool strike = false;
            //sbool spare = false;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("The two scores for this field are {0} and {1}", fields[i, 0], fields[i, 1]);
                int firstRollScore = fields[i, 0];
                int secondRollScore = fields[i, 1];
                int totalScore = firstRollScore + secondRollScore;
                
                if(totalScore > 10){
                    throw new InvalidCastException();
                }

                score += totalScore;

                if(firstRollScore == 10){
                    // the condition where strike = true;
                    score += fields[i+1, 0] + fields[i+1, 1];
                }
                else if(totalScore == 10){
                    // the conditon where spare = true;
                    score += fields[i+1, 0];
                }
            
            System.Console.WriteLine("The score till now is: {0}", score);


            }

            return score;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var resultObj = new Statistics();

            
            int[,] pairScore = {{4, 5}, {10, 0}, {5, 5}, {3, 4}, {4, 5}, {3, 4}, {1, 7}, {4, 4}, {4, 5}, {9, 0}};
            int result = Program.calculateScore(pairScore);
            System.Console.WriteLine(result);

            
        }
    }
}
