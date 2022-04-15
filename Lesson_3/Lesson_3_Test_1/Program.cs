using System;

namespace Lesson_2_Test_5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount newAccount = new BankAccount();  //Первый счет
            BankAccount score = new BankAccount(); // Второй счет
            
            Console.WriteLine(" Баланс: ");
            string symbol = Console.ReadLine();
            bool result = int.TryParse(symbol, out var check); // Проверка на правельный ввод 
            if (result == true)
            {
                newAccount.Balance = check;
            }
            else
            {
                Console.WriteLine("Не првельный ввод.");
            }
             

            Console.WriteLine(" Тип банковского счета: \n 1. Бюджетный счет; \n 2. Валютный счет; \n 3. Замороженный счет; \n 4. Застрахованный счет; \n 5. Текущий счет");

            string symbolTwo = Console.ReadLine();
            bool result2 = int.TryParse(symbolTwo, out var check2); // Проверка на правельный ввод 
            if (result2 == true)
            {
                int resultinNumber = check2;
                newAccount.TypeBankAccount = Convert.ToString(NameSeason(resultinNumber)); // определения типа банковского счета
                          
            }
            else
            {
                Console.WriteLine("Не првельный ввод.");
            }
            var bank = newAccount.TypeBankAccount;


            Console.WriteLine($"Текущее значение счета \n Номер счета: {newAccount.AccountNumber} Баланс: {newAccount.Balance} Тип банковского счета: {bank} ");
            Console.WriteLine();

            Console.WriteLine("Какую сумму хотите снять?");
           newAccount.WithdrawBalance(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Текущее значение счета \n Номер счета: {newAccount.AccountNumber} Баланс: {newAccount.Balance} Тип банковского счета: {bank} ");
           Console.WriteLine("Какую сумму хотите добавить?");
            newAccount.PutBalance(Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine("Какую сумму хотите перевести?");
            int sum = Convert.ToInt32(Console.ReadLine()); 
            
            
            score.Translation(sum, newAccount); // Перевод денежных средств

            Console.WriteLine($"Текущее значение счета \n Номер счета: {newAccount.AccountNumber} Баланс: {newAccount.Balance} Тип банковского счета: {bank} ");
            Console.WriteLine($"Текущее значение счета \n Номер счета: {score.AccountNumber} Баланс: {score.Balance} Тип банковского счета: {bank} ");
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

        public BankAccount()
        {
            Random rar = new Random();
            _accountNumber = rar.Next(100);
        }


        public int AccountNumber
        {
            get { return _accountNumber; }
            
        }

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }

        }
        public string TypeBankAccount
        {
            get { return _typeBankAccount; }
            set { _typeBankAccount = value; }
        }

       public void WithdrawBalance(int amount) // Снять со счета
        {
            if (amount > _balance)
            {
                return;
            }
            _balance = _balance - amount;
        }
        public void PutBalance(int amount) // Положить на счет
        {
            _balance = _balance + amount;
        }
        public void Translation (int sum, BankAccount newAccount) // Перевод со счета на счет
        {
            if (sum > newAccount._balance)
            {
                Console.WriteLine("Не достаточно средств");
                return;
            }
            _balance = sum;
            newAccount._balance = newAccount._balance - sum;
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
