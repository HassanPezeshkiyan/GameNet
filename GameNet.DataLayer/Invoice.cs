//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameNet.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public System.DateTime CreationDate { get; set; }
        public decimal Amount { get; set; }
        public int ControllerQuantity { get; set; }
        public string Time { get; set; }
        public decimal ChargeValue { get; set; }
        public int ConsoleId { get; set; }
        public string NCreationDate { get; set; }
    }
}
