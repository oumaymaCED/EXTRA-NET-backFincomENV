using System;
using System.Collections.Generic;

namespace DataAccess.Layer.Models;

public partial class WorkingOrder
{
    public Guid WoId { get; set; }

    public byte[] WoTimeStamp { get; set; } = null!;

    public string? WoWorkingOrderNumber { get; set; }

    public Guid? WoEmployeeId { get; set; }

    public Guid WoDossierId { get; set; }

    public Guid? WoDossierAssignmentId { get; set; }

    public Guid? WoMainDossierPartyId { get; set; }

    public Guid? WoFacilityDossierPartyId { get; set; }

    public DateTime WoCreatedDate { get; set; }

    public string? WoCreatedBy { get; set; }

    public DateTime WoLastModifiedDate { get; set; }

    public string? WoLastModifiedBy { get; set; }

    public Guid? WoRepairerId { get; set; }

    public Guid? WoWorkingOrderTypeId { get; set; }

    public Guid? WoWorkingOrderSubTypeId { get; set; }
}
