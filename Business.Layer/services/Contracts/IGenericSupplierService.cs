using Business.Layer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.services.Contracts
{
    public interface IGenericSupplierService
    {
        public Task<SupplierDto> GetSupplierById(Guid SupId);
    }
}
