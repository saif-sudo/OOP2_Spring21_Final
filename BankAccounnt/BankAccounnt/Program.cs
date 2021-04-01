using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Account saif = new Savings("Saif", "001", 5000.0f);
            Account raihan = new Current("Raihan", "002", 2000f);
            Account sakib = new Fixed("Sakib", "003", 1000f, 2015, 10);
            
            Account ss = new SuperSavings("Helal", "004", 100f);
            ss.Deposit(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Kashem", "005", 1000f, 5000);
            overdraft.Transfer(ss, 5000);
            overdraft.Deposit(10000);
            overdraft.ShowInfo();
            overdraft.showAllTransaction();

            Customer customer = new Customer("Saif Raihan");

            raihan.Deposit(10000);
            raihan.Transfer(saif, 5000);
            raihan.showAllTransaction();

            saif.ShowInfo();
            saif.Deposit(2000f);
            saif.Transfer(raihan, 4000);
            saif.Withdraw(3000);
            saif.showAllTransaction();

            //rakib.Deposit(5000);
            //rakib.Withdraw(1000);
            //rakib.ShowInfo();

            //alif.Transfer(utsho, 1000f);
            //utsho.ShowInfo();

            //customer.AddAccount(alif, utsho);
            //customer.AccDetails();
        }
    }
}
