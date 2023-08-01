using Business.Layer.services.Contracts;
using DataAccess.Layer.DataContext;
using Microsoft.AspNetCore.Mvc;
using Business.Layer.DTO;


using DataAccess.Layer.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.Data.SqlClient;

namespace APIII.Controllers
{
    [ApiController]
    [Route("api/Suppliers")]
    public class SupplierController : ControllerBase
    {
        private readonly IGenericSupplierService _taskService;
        private readonly NewRepairDbQaDataContext _context;
        public SupplierController(IGenericSupplierService taskService, NewRepairDbQaDataContext context)
        {
            _taskService = taskService;
            _context = context;

        }
        [HttpGet("{SupId}")]


        public async Task<ActionResult> GetSupplierById(Guid SupId)
        {
            // var response = _context.Suppliers.FromSqlRaw("EXECUTE gettSupplierByIdSupp @id_sup", new SqlParameter("@id_sup", SupId)).AsEnumerable().FirstOrDefault();
            var response = await _taskService.GetSupplierById(SupId);
            if (response == null)
            {
                return NotFound(new { Message = "Supplier not found!" });
            }
            return Ok(new
            {
                supplier = response
            });
        }

    }
}
