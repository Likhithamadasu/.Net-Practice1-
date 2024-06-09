using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threads1
{
    internal class Program
    {
      

public class Account
        {
            public int AccountId { get; set; }
            public double AccountBalance { get; set; }

            public Account(int accountId, double initialBalance)
            {
                AccountId = accountId;
                AccountBalance = initialBalance;
            }

            public void Credit(double amount)
            {
                AccountBalance += amount;
            }

            public void Debit(double amount)
            {
                if (AccountBalance >= amount)
                {
                    AccountBalance -= amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds");
                }
            }
        }

        public class AccountManager
        {
            public Account FromAccount { get; set; }
            public Account ToAccount { get; set; }
            public double AmountToTransfer { get; set; }

            public AccountManager(Account fromAccount, Account toAccount, double amount)
            {
                FromAccount = fromAccount;
                ToAccount = toAccount;
                AmountToTransfer = amount;
            }

            public void Transfer()
            {
                FromAccount.Debit(AmountToTransfer);
                ToAccount.Credit(AmountToTransfer);
                Console.WriteLine($"Transfer of ${AmountToTransfer} from Account {FromAccount.AccountId} to Account {ToAccount.AccountId} successful.");
            }
        }

        class Progress
        {
            private static void ThreadImpl()
            {
             
                Account accountA = new Account(1, 500.0);
                Account accountB = new Account(2, 300.0);

                
                AccountManager accountManager = new AccountManager(accountA, accountB, 200.0);

                
                Thread transferThread = new Thread(new ThreadStart(accountManager.Transfer));

              
                transferThread.Start();

                
                transferThread.Join();

                
                Console.WriteLine($"Account A Balance: {accountA.AccountBalance}");
                Console.WriteLine($"Account B Balance: {accountB.AccountBalance}");
            }

            static void Main(string[] args)
            {
                
                ThreadImpl();
            }
        }

    }
}

