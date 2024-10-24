﻿// Listing 3.24 An example view model class - OrderSummaryViewModel.cs file in the WebApplication1 folder

namespace WebApplication1
{
    public class OrderSummaryViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string BillingAddress { get; set; }
        public bool UseBillingForShipping { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
