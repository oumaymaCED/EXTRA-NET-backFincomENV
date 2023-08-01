using DataAccess.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.DTO
{
    public class DossierDto
    {
        
        public Guid DosId { get; set; }
        public string? DosDossierNumber { get; set; }

        //workingOrder
        public string? WoWorkingOrderNumber { get; set; }

        //WORKINGOrderCost
        public Guid? idworkingOrder { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? Discount { get; set; }
        // Ajouté recennement : 
        public double? Quantity { get; set; }
        public double? TaxRate { get; set; }
        public decimal? UnitPrice { get; set; }

        //TABLE  Service

        public Guid ServiceID { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceShortName { get; set; }
        public string? ServiceLongName { get; set; }

        //TABLE DOSSIER
        public string? DosStatusLongName { get; set; }
        public DateTime? DosIntakeDate { get; set; }
        public DateTime? DosIncidentDate { get; set; }
        public DateTime DosCreatedDate { get; set; }
        public string? DosIncidentCountryId { get; set; }
         
        
    
}

}

