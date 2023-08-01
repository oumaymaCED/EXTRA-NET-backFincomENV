using AutoMapper;
using DataAccess.Layer.repositories.Contracts;
using Business.Layer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Layer.services.Contracts;
using DataAccess.Layer.Models;

namespace Business.Layer.services
{
    
    public class SalesInvoiceService : ISalesInvoiceService
    {
        private readonly ISalesIRepository _taskRepository;
        private readonly IMapper _mapper;


        public SalesInvoiceService(ISalesIRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<List<SalesInvoiceDto>> GetAllSalesInvoice(Guid ClientID) 
        {
            var AllSalesInvoices = _taskRepository.GetAllSalesInvoices(ClientID);
            var SalesInvoiceDtos = _mapper.Map<List<SalesInvoiceDto>>(AllSalesInvoices);
            return SalesInvoiceDtos;
        }

        public async Task<SalesInvoiceDto> GetSalesInvoiceById(Guid ClientID) 
        {
            var salesinvoice = _taskRepository.GetSalesInvoiceById(ClientID);
            return _mapper.Map<SalesInvoiceDto>(salesinvoice);
        }
    }
}
