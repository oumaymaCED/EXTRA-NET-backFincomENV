using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.DTO
{
    public class SalesInvoiceDto
    {
        public Guid SalesId { get; set; }
        public string? SalesNumber { get; set; }
        public DateTime? SalesIDate { get; set; }
        public decimal? SalesTotalGrossAmount { get; set; }
        public decimal? SalesTotalTaxAmount { get; set; }
        public decimal? SalesTotalNetAmount { get; set; }
        public string? SalesDossierNumber { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusName { get; set; }

        //SalesInvoiceLines

        public Guid SalesInvoiceLineId { get; set; }

        public decimal? UnitPriceLine { get; set; }
        public double? QuantityLine { get; set; }
        public decimal? NetAmountLine { get; set; }
        public double? TaxRateLine { get; set; }
        public decimal? TaxAmountLine { get; set; }
        public decimal? DiscountLine { get; set; }
        public decimal? GrossAmountLine { get; set; }




    }
}
