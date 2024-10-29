using System;


public class Program
{

static string userGradeInput;
static int userGrade;

    public static void Main(string []args)
    {
        UserGradeInput();
        LetterGradeCalculator();
    }

//Asks for and translates number grade.
    public static void UserGradeInput()
    {
      Console.WriteLine("Please input your number grade.");
      userGradeInput = Console.ReadLine();
      int userGrade = int.Parse (userGradeInput);
    }

    public static void LetterGradeCalculator()
    {
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
