using System;

class ATM
{
    static void Main()
    {
        int correctPin = 1234;
        int enteredPin;
        double balance = 10000;   
        double withdrawAmount;

        Console.Write("Enter your PIN: ");
        enteredPin = Convert.ToInt32(Console.ReadLine());

        
        if (enteredPin == correctPin)
        {
            Console.WriteLine("PIN Verified Successfully ✅");

            Console.Write("Enter amount to withdraw: ");
            withdrawAmount = Convert.ToDouble(Console.ReadLine());

            
            if (withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine("Withdrawal Successful ✅");
                Console.WriteLine("Remaining Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance ❌");
            }
        }
        else
        {
            Console.WriteLine("Incorrect PIN ❌ Access Denied");
        }
    }
}