using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Library
{
    internal class ExceptionUtility
    {
       
    }
    internal class Bank
    {
        internal uint _totalBankMoney = 0 ;  
        internal void Deposit()
        {

        }
        internal void Withdraw(uint amount)
        {
           
                //// aprire un connession al DB 
                _totalBankMoney -= amount / 0; // ->> ERROR 
                ///  Chiudere la connessione al DB              
            
            WriteOprationOnDB($"Operazione di prelievo completata. {amount} Nome Utente {DateTime.Now}");
        }
            
        internal void WriteOprationOnDB(string msg)
        {
            Console.WriteLine(msg); // --> sCRIVO RISULTATO NEL DATABASE
            Console.WriteLine(msg); // -->  sCRIVO NEL FILE DI LOG
        }
    }   
    public class BankWebApp
    {
        Bank Bank  = new Bank();
        public void Deposit()
        {
            Bank.Deposit();
        }
        public void Withdraw(uint amount)
        {
            // Break -> Throw Exception 
            try
            {
                Bank.Withdraw(amount);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message); //Log

                throw; // -> Finishi la funzione e rimamandaindiretro  l'errrore
            }


        }
    }
}
