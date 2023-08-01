using System;
using System.Collections.Generic;
using DataAccess.Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Layer.DataContext;

public partial class NewRepairDbQaDataContext : DbContext
{
    public NewRepairDbQaDataContext()
    {
    }

    public NewRepairDbQaDataContext(DbContextOptions<NewRepairDbQaDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WorkingOrderLine> WorkingOrderLines { get; set; }
    public virtual DbSet<Dossier> Dossiers { get; set; }
    public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }



    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<WorkingOrder> WorkingOrders { get; set; }

   // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   //ng To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //    => optionsBuilder.UseSqlServer("Server=DESKTOP-9CJJV5K\\SQLEXPRESS;Database=NewRepair-db-qa-data;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;Connect timeout=1500");
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         optionsBuilder.UseSqlServer("Server=LAP-TUN-6V8PH33\\SQLEXPRESS;Database=NewRepair-db-qa-data;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;Connect timeout=1500");

        //optionsBuilder.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        //optionsBuilder.UseLazyLoadingProxies(true);
        optionsBuilder.UseSqlServer("Server=LAP-TUN-6V8PH33\\SQLEXPRESS;Database=NewRepair-db-qa-data;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;Connect timeout=1500", builder => builder.CommandTimeout(300));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");
        modelBuilder.Entity<Dossier>().HasKey(d => d.DosId);
        modelBuilder.Entity<Supplier>().HasKey(d => d.SupId);
        modelBuilder.Entity<Product>().HasKey(d => d.PrdCode);
        modelBuilder.Entity<WorkingOrder>().HasKey(d => d.WoId);

        modelBuilder.Entity<WorkingOrderLine>(entity =>
        {
            entity.HasKey(e => e.WolId);

            entity.ToTable("WorkingOrderLines", "dos", tb => tb.HasTrigger("th_dos_WorkingOrderLines_TraceHistory"));

            entity.Property(e => e.WolId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("WOL_Id");
            entity.Property(e => e.WolCreatedBy)
                .HasMaxLength(250)
                .HasColumnName("WOL_CreatedBy");
            entity.Property(e => e.WolCreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("WOL_CreatedDate");
            entity.Property(e => e.WolCurrencyCode)
                .HasMaxLength(3)
                .HasColumnName("WOL_CurrencyCode");
            entity.Property(e => e.WolDeliveryAddressId).HasColumnName("WOL_DeliveryAddress_Id");
            entity.Property(e => e.WolDeliveryDate).HasColumnName("WOL_DeliveryDate");
            entity.Property(e => e.WolDossierPartyId).HasColumnName("WOL_DossierParty_Id");
            entity.Property(e => e.WolDossierWorkActivityId).HasColumnName("WOL_DossierWorkActivity_Id");
            entity.Property(e => e.WolDueDate)
                .HasColumnType("datetime")
                .HasColumnName("WOL_DueDate");
            entity.Property(e => e.WolInvoiceToPayorAddressId).HasColumnName("WOL_InvoiceToPayorAddress_Id");
            entity.Property(e => e.WolInvoiceToPayorId).HasColumnName("WOL_InvoiceToPayor_Id");
            entity.Property(e => e.WolIsClosed).HasColumnName("WOL_IsClosed");
            entity.Property(e => e.WolIsExecuteVatdeductable).HasColumnName("WOL_IsExecuteVATdeductable");
            entity.Property(e => e.WolIsForProductSelection).HasColumnName("WOL_IsForProductSelection");
            entity.Property(e => e.WolIsManuallyAdded).HasColumnName("WOL_IsManuallyAdded");
            entity.Property(e => e.WolIsOwnRisk).HasColumnName("WOL_IsOwnRisk");
            entity.Property(e => e.WolIsPayorDossierParty).HasColumnName("WOL_IsPayorDossierParty");
            entity.Property(e => e.WolIsSubContractor).HasColumnName("WOL_IsSubContractor");
            entity.Property(e => e.WolLastModifiedBy)
                .HasMaxLength(250)
                .HasColumnName("WOL_LastModifiedBy");
            entity.Property(e => e.WolLastModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("WOL_LastModifiedDate");
            entity.Property(e => e.WolLineNumber).HasColumnName("WOL_LineNumber");
            entity.Property(e => e.WolParentId).HasColumnName("WOL_Parent_Id");
            entity.Property(e => e.WolSubContractorId).HasColumnName("WOL_SubContractor_Id");
            entity.Property(e => e.WolSupplierId).HasColumnName("WOL_Supplier_Id");
            entity.Property(e => e.WolTaskWorkActivityId).HasColumnName("WOL_TaskWorkActivity_Id");
            entity.Property(e => e.WolTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("WOL_TimeStamp");
            entity.Property(e => e.WolWorkingOrderId).HasColumnName("WOL_WorkingOrder_Id");
            entity.Property(e => e.WolYourReference)
                .HasMaxLength(30)
                .HasColumnName("WOL_YourReference");

            entity.HasOne(d => d.WolParent).WithMany(p => p.InverseWolParent)
                .HasForeignKey(d => d.WolParentId)
                .HasConstraintName("FK_WorkingOrderLines_WOL_Parent_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
