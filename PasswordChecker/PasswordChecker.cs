/* Make a program that measures the strength of any given password based on the following criteria. A strong password:

is at least 8 characters long
has lowercase letters
has uppercase letters
has numerical digits
has symbols, like #, ?, !
The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password. */

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*()";

      Console.WriteLine("Enter a password to check its strength:");
      string userInput = Console.ReadLine();

      int score = 0;

      if (userInput.Length >= minLength){
        score++;
      }

      if(Tools.Contains(userInput,uppercase)){
        score++;
      }

      if(Tools.Contains(userInput,lowercase)){
        score++;
      }

      if(Tools.Contains(userInput,digits)){
        score++;
      }

      if(Tools.Contains(userInput,specialChars)){
        score++;
      }

      Console.WriteLine("Your password strength score is: " + score);

      switch(score) {
        case 5:
        Console.WriteLine("You password strength is extremely strong");
        break;
        case 4:
        Console.WriteLine("You password strength is extremely strong");
        break;
        case 3:
        Console.WriteLine("You password strength is strong");
        break;
        case 2:
        Console.WriteLine("You password strength is medium");
        break;
        case 1:
        Console.WriteLine("You password strength is weak");
        break;
        default:
        Console.WriteLine("Your password doesn’t meet any of the standards");
        break;
      }
    
    }
  }
}
