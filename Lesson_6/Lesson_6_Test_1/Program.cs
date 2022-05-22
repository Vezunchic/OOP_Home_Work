using System;

namespace Lesson_2_Test_5
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();  //Первый счет
            BankAccount account2 = new BankAccount(); // Второй счет


            account1.FillingBalance();//заполнение баланса 
            account1.FillingTypeBankAccount();//заполнение типа счета 

            var bank = account1.TypeBankAccount;
            Console.WriteLine($"Текущее значение счета 1 \n Номер счета: {account1.AccountNumber} Баланс: {account1.Balance} Тип банковского счета: {bank} \n");

            Console.WriteLine("Какую сумму хотите снять?");
            account1.WithdrawBalance(Convert.ToInt32(Console.ReadLine()));
             Console.WriteLine($"\nТекущее значение счета 1 \n {account1} \n");
             Console.WriteLine("Какую сумму хотите добавить?");
            account1.PutBalance(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"\nТекущее значение счета 1 \n {account1} \n");

            account2.FillingBalance();//заполнение баланса 
            account2.FillingTypeBankAccount();//заполнение типа счета  

            var bank2 = account2.TypeBankAccount;
            Console.WriteLine($"Текущее значение счета 2 \n Номер счета: {account2.AccountNumber} Баланс: {account2.Balance} Тип банковского счета: {bank2} \n ");
            
            Console.WriteLine("Какую сумму хотите перевести?");
            int sum = Convert.ToInt32(Console.ReadLine());

            account2.Translation(sum, account1); // Перевод денежных средств на второй счет

            Console.WriteLine();
            Console.WriteLine($"Текущее значение счета 1: \n {account1} \n ");
            Console.WriteLine($"Текущее значение счета 2: \n {account2} \n ");
            
            Console.WriteLine($" \n == {account1 == account2} \n != {account1 != account2}");
            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        private int _accountNumber;
        private int _balance;
        private TypeAccount _typeBankAccount;

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
        public TypeAccount TypeBankAccount
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
        public void Translation(int sum, BankAccount account1) // Перевод со счета на счет
        {
            if (sum > account1._balance)
            {
                Console.WriteLine("Не достаточно средств");
                return;
            }
            _balance = _balance + sum;
            account1._balance = account1._balance - sum;
            
        }
        public static bool operator ==(BankAccount account1, BankAccount account2)
        {
            return account1.Balance == account2.Balance && account1.TypeBankAccount == account2.TypeBankAccount && account1.AccountNumber == account2.AccountNumber;
        }
        public static bool operator !=(BankAccount account1, BankAccount account2)
        {
            return account1.Balance != account2.Balance || account1.TypeBankAccount != account2.TypeBankAccount || account1.AccountNumber != account2.AccountNumber;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is not BankAccount)
            {
                return false;
            }
            var account2 = (BankAccount)obj;
            if (this.Balance == account2.Balance && this.TypeBankAccount == account2.TypeBankAccount && this.AccountNumber == account2.AccountNumber)
            {
                return true;
            }

            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(AccountNumber, TypeBankAccount, Balance);

        }
        public override string ToString()
        {

            return string.Format($"Номер аккаунта : \t { _accountNumber}\n Баланс : \t\t { _balance}\n Тип акаунта : \t {_typeBankAccount}");
        }
        public void FillingBalance()
        {
            Console.WriteLine(" Баланс: ");
            string symbol = Console.ReadLine();
            bool result = int.TryParse(symbol, out var check); // Проверка на правельный ввод 
            if (result == true)
            {
                Balance = check;
            }
            else
            {
                Console.WriteLine("Не правельный ввод.");
            }
        }
        public void FillingTypeBankAccount()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Тип банковского счета: \n 1. Бюджетный счет; \n 2. Валютный счет; \n 3. Замороженный счет; \n 4. Застрахованный счет; \n 5. Текущий счет");

            string symbolTwo = Console.ReadLine();
            bool result2 = int.TryParse(symbolTwo, out var check2); // Проверка на правельный ввод 
            if (result2 == true)
            {
                TypeBankAccount = GetTypeAccountFromNumber(check2);
                
            }
            else
            {
                Console.WriteLine("Не првельный ввод.");
            }
            
        }
        private TypeAccount GetTypeAccountFromNumber(int number) // определение типа банковского счета
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

    public enum TypeAccount
    {
        Other,
        Budget_Account,
        Currency_Account,
        Frozen_Account,
        Insured_Account,
        Current_Account

    }

}
