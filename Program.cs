using System;


public class Program
{

static string userGradeInput;
static int userGrade;

    public static void Main(string []args)
    {
        LetterGradeCalculator();
    }
    public static void LetterGradeCalculator()
    {
    Console.WriteLine("Please input your number grade.");
      userGradeInput = Console.ReadLine();
      int userGrade = int.Parse (userGradeInput);
        
        if (userGrade >= 100)
        {
            Console.WriteLine("Letter Grade: A+");
            Console.WriteLine("Wow! ", userGrade, "..! That's impressive!");
        }
        else if(userGrade >= 90)
        {
            Console.WriteLine("Letter Grade: A");
            Console.WriteLine("Very nice!");
        }
        else if(userGrade >= 80)
        {
            Console.WriteLine("Letter grade: B");
            Console.WriteLine("Keep it up!");
        }
        else if(userGrade >= 70)
        {
            Console.WriteLine("Letter Grade: C");
            Console.WriteLine("You got this, keep working!");
        }
        else if(userGrade >= 60)
        {
            Console.WriteLine("Letter Grade: D");
            Console.WriteLine("Keep trying!");
        }
        else
        {
            Console.WriteLine("Letter Grade: E");
            Console.WriteLine("Don't give up!");
        }

    }
}
