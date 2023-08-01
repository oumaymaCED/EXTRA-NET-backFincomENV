using System;
using System.Collections.Generic;

namespace DataAccess.Layer.Models;

public partial class Product
{
    public Guid PrdId { get; set; }

    public byte[] PrdTimeStamp { get; set; } = null!;

    public string PrdCode { get; set; } = null!;

    public string? PrdShortName { get; set; }

    public string PrdLongName { get; set; } = null!;

    public bool PrdInactive { get; set; }

    public Guid PrdProductGroupId { get; set; }

    public Guid? PrdDepartmentId { get; set; }

    public string? PrdSalesLedgerAccount { get; set; }

    public string? PrdPurchaseLedgerAccount { get; set; }

    public string? PrdSalesTaxCodeId { get; set; }

    public string? PrdPurchaseTaxCodeId { get; set; }

    public string? PrdConsolidationCreditorNumber { get; set; }

    public string? PrdLedgerAccount { get; set; }

    public bool PrdPurchaseTaxIncluded { get; set; }

    public bool PrdPurchaseTaxApplicable { get; set; }

    public Guid? PrdLocalizableEntryId { get; set; }

    public bool PrdIsTransitoryItem { get; set; }

    public DateTime PrdCreatedDate { get; set; }

    public string? PrdCreatedBy { get; set; }

    public DateTime PrdLastModifiedDate { get; set; }

    public string? PrdLastModifiedBy { get; set; }

    public Guid? PrdProductTypeId { get; set; }

    public Guid? PrdProductClassificationId { get; set; }

    public DateTime? PrdEffectiveDate { get; set; }

    public DateTime? PrdTerminationDate { get; set; }
}
