using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Layer.Models;

public partial class Dossier
{
    [Key]     
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
    //Ajouté
    public double? Quantity { get; set; }
    public double? TaxRate { get; set; }
    public decimal? UnitPrice { get; set; }




    //TABLE  Service
    public Guid ServiceID { get; set; }

    public string? ServiceCode { get; set; }

    public string? ServiceShortName { get; set; }

    public string? ServiceLongName { get; set; }




    //TABLE DOSSIER

    //public string? DosCurrentStatusCode { get; set; }

    
    public string? DosStatusLongName { get; set; }

    public DateTime? DosIntakeDate { get; set; }

    public DateTime? DosIncidentDate { get; set; }


    public DateTime DosCreatedDate { get; set; }

   
    public string? DosIncidentCountryId { get; set; }
}
