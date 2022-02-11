using AbpAngularExample.DTOs.Models;
using AbpAngularExample.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpAngularExample.DTOs.Cars
{
    public class CarDto : EntityDto<int>
    {
        public string Title { get; set; }

        public int ModelID { get; set; }

        public ModelDto Model { get; set; }

        public eFuelType FuelType { get; set; }

        public int Year { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal InvoiceAmount { get; set; }

    }
}
