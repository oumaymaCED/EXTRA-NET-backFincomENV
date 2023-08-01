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
using AutoMapper;
using Nito.AsyncEx;

namespace DataAccess.Layer.repositories
{
    public class DossierRepository : IGenericRepository
    {
        private const string Sql = "EXECUTE gettDossierByIdSuup {0}";
        private readonly NewRepairDbQaDataContext _context;

        public DossierRepository(NewRepairDbQaDataContext context)
        {
            _context = context;
        }

       
        public   List<Dossier> GetAllDossiers(Guid SupId)
        {
            var dossierList =  _context.Dossiers.FromSqlRaw("EXECUTE gettDossierByIdSuup @id_sup", new SqlParameter("@id_sup", SupId)).ToList();
            
            return dossierList;
        }


        public  Dossier GetDossierById(Guid SupId)
        
         {
                var dossier = _context.Dossiers.FromSqlRaw("EXECUTE gettDossierByIdSuup @id_sup", new SqlParameter("@id_sup", SupId)).AsEnumerable().FirstOrDefault();

            if (dossier == null )
                {
                    // Gérer le cas où la requête ne retourne pas de résultat
                    throw new Exception("No dossier found");
                }
            return dossier;
        }

       
    }
}
