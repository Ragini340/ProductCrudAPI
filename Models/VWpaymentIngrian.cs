using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VWpaymentIngrian
    {
        public int PaymentId { get; set; }
        public int ClassTypeId { get; set; }
        public int PaymentMethodTypeCdId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int? CardTypeCdId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? BankName { get; set; }
        public string? BankContactName { get; set; }
        public string? FederalRoutingNum { get; set; }
        public string? ConfirmationNum { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? NameOnCard { get; set; }
        public string? CheckNum { get; set; }
        public string? Abanum { get; set; }
        public string? AccountNum { get; set; }
        public int? OutOfStateFlag { get; set; }
        public string? AuthorizationNum { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? AccountNum2 { get; set; }
    }
}
