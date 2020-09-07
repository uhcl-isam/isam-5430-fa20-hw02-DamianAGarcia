using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            // read in account number
            Console.WriteLine("Enter your account number");
            int account = Convert.ToInt32(Console.ReadLine());

            // Enter your sentinel loop here
            while (account > 0)
            {
                int beginningBalance = Convert.ToInt32(Console.ReadLine());
                int charges = Convert.ToInt32(Console.ReadLine());
                int credits = Convert.ToInt32(Console.ReadLine());
                int newBalance = (beginningBalance + charges) - credits;
                Console.WriteLine("Your new balance is " + newBalance);
                if (newBalance < 0)
                {
                    Console.WriteLine("You have exceeded your credit limit");
                }
            }
        }
    }
}
