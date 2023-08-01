using Business.Layer.services.Contracts;
using DataAccess.Layer.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace APIII.Controllers
{
    [ApiController]
    [Route("api/SalesInvoices")]
    public class SalesInvoiceController : ControllerBase
    {
        private readonly ISalesInvoiceService _taskService;
        private readonly NewRepairDbQaDataContext _context;
        
        public SalesInvoiceController(ISalesInvoiceService taskService, NewRepairDbQaDataContext context)
        {
            _taskService = taskService;
            _context = context;


        }
        [Route("ALLSalesInvoices")]
        [HttpGet]
        public async Task<ActionResult> GetAllSalesInvoice(Guid ClientID)
        {
            var response = await _taskService.GetAllSalesInvoice(ClientID);

            if (response == null)
            {
                return NotFound(new { Message = "Sales Invoices not found!" });
            }
            return Ok(response); 



        }
    }
}
