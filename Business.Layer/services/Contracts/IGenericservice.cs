using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Layer.DTO;
using DataAccess.Layer.Models;

namespace Business.Layer.services.Contracts
{
    public interface IGenericservice
    {
        Task<DossierDto> GetDossierById(Guid SupId);
        Task<List<DossierDto>> GetAllDossiers(Guid SupId);
    }
}
