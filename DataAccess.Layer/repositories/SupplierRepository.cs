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
    public class SupplierRepository : IgenericSupRepository
    {
        private const string Sql = "EXECUTE gettSupplierByIdSupp {0}";
        private readonly NewRepairDbQaDataContext _context;

    public SupplierRepository(NewRepairDbQaDataContext context)
    {
        _context = context;
    }
        public Supplier GetSupplierById(Guid SupId)
        {
            var Supplier = _context.Suppliers.FromSqlRaw("EXECUTE gettSupplierByIdSupp @id_sup", new SqlParameter("@id_sup", SupId)).AsEnumerable().FirstOrDefault();

            if (Supplier == null)
            {
                // Gérer le cas où la requête ne retourne pas de résultat
                throw new Exception("Dossier not found");
            }
            return Supplier;
        }
    }
}
