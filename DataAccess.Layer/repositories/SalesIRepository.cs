using DataAccess.Layer.DataContext;
using DataAccess.Layer.Models;
using DataAccess.Layer.repositories.Contracts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.repositories
{
    public class SalesIRepository : ISalesIRepository
    {
        private const string Sql = "EXECUTE getSalesInvoice {0}";
        private readonly NewRepairDbQaDataContext _context;

        public SalesIRepository(NewRepairDbQaDataContext context)
        {
            _context = context;
        }


        public List<SalesInvoice> GetAllSalesInvoices(Guid ClientID)
        {
            var SalesInvoiceList  = _context.SalesInvoices.FromSqlRaw("EXECUTE getSalesInvoice @id_client", new SqlParameter("@id_client", ClientID)).ToList();

            return SalesInvoiceList; 
        }

        public SalesInvoice GetSalesInvoiceById(Guid ClientID)
        {
            var SalesInvoice = _context.SalesInvoices.FromSqlRaw("EXECUTE getSalesInvoice @id_client", new SqlParameter("@id_client", ClientID)).AsEnumerable().FirstOrDefault();

            if (SalesInvoice == null)
            {
                // Gérer le cas où la requête ne retourne pas de résultat
                throw new Exception("No sales Invoice found");
            }
            return SalesInvoice; throw new NotImplementedException();
        }
    }
}
