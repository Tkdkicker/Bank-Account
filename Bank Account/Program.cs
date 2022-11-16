namespace Bank_Account
    {
    class Program
    {
        static void Main(string[] args)
        {
            String UserChoice;
            Decimal amount;
            Account testAccount;
            Decimal overdraft;

            overdraft = 0;

            testAccount = new Account();
            testAccount.Deposit(100);

            do
            {
                Console.WriteLine("What would you like to do");
                UserChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "showbalance":
                        amount = testAccount.GetBalance();
                        Console.WriteLine("Your Balance is " + amount);
                        break;

                    case "deposit":
                        Console.WriteLine("How much do you want to pay out");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        testAccount.Deposit(amount);
                        break;

                    case "withdraw":
                        Console.WriteLine("How much do you want to withdraw");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        testAccount.Withdraw(amount);
                        if (amount < overdraft)
                        {
                            Console.WriteLine("You will go into overdraft if you take out this amount");
                            overdraft = Convert.ToDecimal(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Confirmed: Please give the customer £: " + amount);
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Have a nice day :)");
                        break;
                }
            } while (UserChoice != "exit");
            Console.ReadLine();
        }
    }
    }
