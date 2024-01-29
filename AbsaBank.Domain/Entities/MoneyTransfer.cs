using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Domain.Entities
{
    public class MoneyTransfer
    {
        public Guid TransactionId{ get; set; }
        public string CreditAccount { get; set; }
        public string DebitAccount { get; set; }
        public decimal TransferAmount { get; set; }
        public string SenderBic { get; set; }
        public string RecipientBic { get; set; }
        public Guid TransactionStatus { get; set; }
        public DateTime TransactionDate { get; set; }
        public MoneyTransfer() { }
        public MoneyTransfer(string creditAccount, string debitAccount, decimal transferAmount,string senderBic, string recipientBic, Guid transactionStatus, DateTime transactionDate)
        {
            TransactionId = Guid.NewGuid();
            CreditAccount = creditAccount;
            DebitAccount = debitAccount;
            TransferAmount = transferAmount;
            SenderBic = senderBic;
            RecipientBic = recipientBic;
            TransactionStatus = transactionStatus;
            TransactionDate = transactionDate;  

        }
        public static MoneyTransfer AddMoneyTransfer(string creditAccount,string debitAccount,decimal transferAmount, string senderBic,string description,string recipientBic,Guid transactionStatus,DateTime transactionDate)
        {
            return new MoneyTransfer(creditAccount,debitAccount,transferAmount,senderBic,recipientBic,transactionStatus,transactionDate);
        }
    }

}
