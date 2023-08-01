using DataAccess.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.repositories.Contracts
{
    public interface IgenericSupRepository
    {
        Supplier GetSupplierById(Guid SupId);
        
    }
}
