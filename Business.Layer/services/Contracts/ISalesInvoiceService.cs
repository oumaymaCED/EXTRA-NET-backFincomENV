using Business.Layer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.services.Contracts
{
    public interface ISalesInvoiceService
    {
        Task<SalesInvoiceDto> GetSalesInvoiceById(Guid ClientID);
        Task<List<SalesInvoiceDto>> GetAllSalesInvoice(Guid ClientID);
    }
}
