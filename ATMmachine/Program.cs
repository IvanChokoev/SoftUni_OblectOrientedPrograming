using System;
using System.Collections.Generic;
using System.Linq;

namespace ATMmachine
{
    public class cardHolder
    {
        String cardNumber;
        int pin;
        String firstName;
        String lastName;
        double balance;

        public cardHolder(String cardNumber, int pin, String firstName, String lastName, double balance)
        {
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public String getNumber()
        {
            return cardNumber;
        }

        public int getPin()
        {
            return pin;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setNumber(String newCardNumber)
        {
            cardNumber = newCardNumber;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

        public static void Main(String[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }

            void deposit(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to deposit? ");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposit);
                Console.WriteLine("Thank you for your deposit. Your New balance is: " + currentUser.getBalance());
            }

            void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to withdraw? ");
                double withdrawal = Double.Parse(Console.ReadLine());
                //check if user has enough $ to withdraw
                if (currentUser.getBalance() > withdrawal)
                {
                    Console.WriteLine("Error! Insufficient balance.");
                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawal);
                    Console.WriteLine("Transaction complete, Thank you!");
                }
            }

            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Current Balance: " + currentUser.getBalance());
            }

            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("4532772818532958", 1234, "John", "Marston", 150.32));
            cardHolders.Add(new cardHolder("4569307923812294", 4321, "Ralph", "Fines", 321.50));
            cardHolders.Add(new cardHolder("7869048867392153", 9090, "Don", "Rudolph", 105.59));
            cardHolders.Add(new cardHolder("8795477691273356", 2468, "Mary", "Tate", 869.22));
            cardHolders.Add(new cardHolder("6748294018763492", 3579, "Kate", "Montana", 59.12));

            //prompt user
            Console.WriteLine("Welcome to SimpleATM");
            Console.WriteLine("Please insert your debit card number: ");
            String debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    // check against our DB
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card no recognized. Please try again."); }
                }
                catch { Console.WriteLine("Card no recognized. Please try again."); }
            }

            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("Incorrect PIN. Please try again."); }
                }
                catch { Console.WriteLine("Incorrect PIN. Please try again."); }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName() + "!");
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch{}
                if (option == 1) { deposit(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
                
            } while (option != 4);
            Console.WriteLine("Thank you! Have a nice day!");
        }


    }
}
