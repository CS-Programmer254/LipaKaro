using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Domian.Entities
{
    public class TransactionStatus
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string TransactionDescription { get; set; }

        public TransactionStatus() { }
        public TransactionStatus(string code,string transactionDescription)
        {  
            Id= Guid.NewGuid();
            Code = code;
            TransactionDescription= transactionDescription;
            
        }
        public static TransactionStatus AddTransactionStatus(string code,string transactionDescription)
        {
            return new TransactionStatus(code,transactionDescription);  

        }

    }
}
