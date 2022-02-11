using AbpAngularExample.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpAngularExample.DTOs.Cars
{
    public class CarCreateDto
    {
        public string Title { get; set; }

        public int ModelId { get; set; }

        public eFuelType FuelType { get; set; }

        public int Year { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal InvoiceAmount { get; set; }
    }
}
