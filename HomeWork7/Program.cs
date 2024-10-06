namespace HomeWork7
{
    public class Lkuchava
    {
        string name;
        string lastname;
        int age;
        string personalNumber;
        string phoneNumber;
        string email;

        public Lkuchava(string name, string lastname, int age, string personalNumber, string phoneNumber, string email)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.personalNumber = personalNumber;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void printLkuchava()
        {
            Console.WriteLine($"{name},{lastname},{age},{personalNumber},{phoneNumber},{email}");
        }
    }

    public class Account
    {
        private string accountNumber;
        public string currency;
        public int balance;

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                if (accountNumber.Length == 22)
                {
                    accountNumber = value;
                }
                else
                {
                    Console.WriteLine("use correct account Number");
                }
            }
        }
        public string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                if (currency.Length == 3)
                {
                    currency = value;
                }
                else
                {
                    Console.WriteLine("use correct currency ");
                }
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (balance > 0)
                {
                    balance = value;
                }
                else
                {

                    Console.WriteLine("use correct balance");
                }

            }
        }

        public void fillAccount(int amount)
        {
            this.balance += amount;
        }
        public void withdrawAccount(int amount) 
        {
            balance -= amount;
        }
    }

    public class Client
    {
        public string name;
        public string lastname;
        public string personalNumber;
        Account account;
    }
        internal class Program
        {

            static void Main(string[] args)
            {
                /*Lkuchava lkuchava = new Lkuchava("Levani", "Kuchava", 33, "12345678910", "598264226", "lev.kuchava@gmail.com");
                lkuchava.printLkuchava();*/

                
            }
        }
    }

