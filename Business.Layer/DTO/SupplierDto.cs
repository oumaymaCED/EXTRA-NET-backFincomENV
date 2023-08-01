using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.DTO
{
    public class SupplierDto
    {
        public Guid SupId { get; set; }

        // OrganisationUnit 
        public string? SupplierName { get; set; }

        public string? SupplierCode { get; set; }

        public string? SupplierEmail { get; set; }

        public string? SupplierPhone { get; set; }

        public Guid SupplierAdress { get; set; }

        //TABLE ADRESS

        public string? StreetName { get; set; }

        public string? City { get; set; }

        public string? PostalCode { get; set; }

        public string? HouseNumber { get; set; }


        //Dosier
        //public byte[] SupTimeStamp { get; set; } = null!;


        public Guid? SupPartnerId { get; set; }

        public string? SupExternalCode { get; set; }

        public string? SupCultureCodePreferredLanguage { get; set; }

        public string? SupPaymentBatchEmail { get; set; }

        public bool? SupIsPreferredSupplier { get; set; }

        public string? SupCurrencyCode { get; set; }

        public bool? SupInactive { get; set; }

        public DateTime SupCreatedDate { get; set; }

        public DateTime SupLastModifiedDate { get; set; }

    }
}

