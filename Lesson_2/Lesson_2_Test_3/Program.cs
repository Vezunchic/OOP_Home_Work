using System;

namespace Lesson_2_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Введите число: ");

            BankAccount newAccount = new BankAccount(Convert.ToInt32(Console.ReadLine())); // создание обьекта через конструктор без поля "банкоский счет"
            //BankAccount newAccount = new BankAccount(Console.ReadLine()); // создание обьекта через конструктор без поля "баланс" (второй вариант)
            
            int number = newAccount.AccountNumber;
            int account = newAccount.Balance;

            Console.WriteLine(" Тип банковского счета: \n 1. Бюджетный счет; \n 2. Валютный счет; \n 3. Замороженный счет; \n 4. Застрахованный счет; \n 5. Текущий счет");

            var bank = newAccount.TypeBankAccount;
            //var bank = NameSeason(Convert.ToInt32(accountNumber.TypeBankAccount));// вывод типа банковского счета ко второму варианту через enum
            
            Console.WriteLine();
            Console.WriteLine($" Номер счета: {number} Баланс: {account} Тип банковского счета: {bank} ");
            Console.ReadKey();
        }

        static TypeAccount NameSeason(int number) // определение типа банковского счета
        {

            switch (number)
            {
                case 1:
                    return TypeAccount.Budget_Account;

                case 2:
                    return TypeAccount.Currency_Account;

                case 3:
                    return TypeAccount.Frozen_Account;

                case 4:
                    return TypeAccount.Insured_Account;

                case 5:
                    return TypeAccount.Current_Account;
            }

            return TypeAccount.Other;
        }
    }
    public class BankAccount
    {
        private int _accountNumber;
        private int _balance;
        private string _typeBankAccount;


        private static int _staticNumber;// статическая переменная

        public void SetAccountNumber() // изменяет статическую переменную
        {
            
            _accountNumber = _staticNumber + 1;
            _staticNumber = _accountNumber;
        }


       /* Random newNumber = new Random();
        
        public int RandomNumbers() // создает рандомный набор чисел 
        {
            int d = newNumber.Next(1, 1000);
            return d;
        }*/

        public BankAccount( int balance) // поле баланс
        {
            //_accountNumber = RandomNumbers();
            SetAccountNumber();
           _balance = balance;
        }
        public BankAccount( string typeBankAccount)// тип банковского счета
        {
            // _accountNumber = RandomNumbers();
            SetAccountNumber();
            _typeBankAccount = typeBankAccount;
        }
        public BankAccount(int balace, string typeBankAccount)// тип багнковского счета, поле баланс
        {
            //_accountNumber = RandomNumbers();
            SetAccountNumber();
            _balance = balace;
            _typeBankAccount = typeBankAccount;
        }
        
        
        public int AccountNumber
        {
            get { return _accountNumber; }
            
        } 
        public int Balance
        {
            get { return _balance; }
            

        }
        public string TypeBankAccount
        {
            get { return _typeBankAccount; }
            
        }
 
     }
    enum TypeAccount
    {
        Other,
        Budget_Account,
        Currency_Account,
        Frozen_Account,
        Insured_Account,
        Current_Account

    }

}
