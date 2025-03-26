using System.Text.RegularExpressions;

namespace Myprogram;

public class Program
{
    static void Main(string[] args)
    {
     
        // string manipulator
        string pattern = @"^.{8,}$";
        string pattern1 = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";
        string pattern2 = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%])[A-Za-z/d!@#$%].{8,}$";
        string password = "aice00024@#!";
        
        // if the string matches the pattern, returns true, otherwise return false
        var result = Regex.IsMatch(password, pattern2);
        
        Console.WriteLine(result);

      
    }

 
    
}
