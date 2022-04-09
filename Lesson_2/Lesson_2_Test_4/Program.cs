using System;

namespace Lesson_2_Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите номер счета: ");

            BankAccount newAccount = new BankAccount();
            newAccount.AccountNumber = Convert.ToInt32(Console.ReadLine());
            int number = newAccount.AccountNumber;

            Console.WriteLine(" Баланс: ");

            newAccount.Balance = Convert.ToInt32(Console.ReadLine());
            int account = newAccount.Balance;

            Console.WriteLine(" Тип банковского счета: \n 1. Бюджетный счет; \n 2. Валютный счет; \n 3. Замороженный счет; \n 4. Застрахованный счет; \n 5. Текущий счет");

            int resultinNumber = Convert.ToInt32(Console.ReadLine());
            newAccount.TypeBankAccount = Convert.ToString(NameSeason(resultinNumber)); // определения типа банковского счета
            var bank = newAccount.TypeBankAccount;

            Console.WriteLine($" Номер счета: {number} Баланс: {account} Тип банковского счета: {bank} ");

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
        public int AccountNumber { get; set; }

        public int Balance { get; set; }

        public string TypeBankAccount { get; set; }

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
