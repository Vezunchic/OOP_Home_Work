using System;

namespace Lesson_2_Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите номер счета: ");

            BankAccount newAccount = new BankAccount();
            newAccount.SetAccountNumber (Convert.ToInt32(Console.ReadLine()));
            int number = newAccount.GetAccountNumber();

            Console.WriteLine(" Баланс: ");

            newAccount.SetBalance(Convert.ToInt32(Console.ReadLine()));
            int account = newAccount.GetBalance();
            
            Console.WriteLine(" Тип банковского счета: \n 1. Бюджетный счет; \n 2. Валютный счет; \n 3. Замороженный счет; \n 4. Застрахованный счет; \n 5. Текущий счет");

            int resultinNumber = Convert.ToInt32(Console.ReadLine());
            newAccount.SetTypeBankAccount(Convert.ToString(NameSeason(resultinNumber))); // определения типа банковского счета
            var bank = newAccount.GetTypeBankAccount();

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

        public int GetAccountNumber()
        {
            return _accountNumber;
        }
        public void SetAccountNumber(int accountNumber)
        {
            _accountNumber = accountNumber;
        }
        public int GetBalance()
        {
            return _balance;
        }
        public void SetBalance(int balance)
        {
            _balance = balance;
        }
        public string GetTypeBankAccount()
        {
            return _typeBankAccount;
            
        }
        public void SetTypeBankAccount(string typeBankAccount)
        {
            _typeBankAccount = typeBankAccount;
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
