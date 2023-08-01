using Business.Layer.DTO;
using Business.Layer.services.Contracts;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Layer.Models;
using Microsoft.EntityFrameworkCore;
using DataAccess.Layer.DataContext;
using Microsoft.Data.SqlClient;
using DataAccess.Layer.repositories;
using AutoMapper;

namespace APIII.Controllers
{
    [ApiController]
    [Route("api/Dossiers")]
    public class DossierController : ControllerBase
    {
        private readonly IGenericservice _taskService;
        private readonly NewRepairDbQaDataContext _context;
       
        public DossierController(IGenericservice taskService, NewRepairDbQaDataContext  context) 
        {
            _taskService = taskService;
            _context= context;
            

        }
       /* [HttpGet("{SupId}")]
        
        public async Task<ActionResult> GetDossierById(Guid SupId)
        {
            //var response = _context.Dossiers.FromSqlRaw("EXECUTE gettDossierByIdSuup @id_sup", new SqlParameter("@id_sup",SupId)).AsEnumerable().FirstOrDefault();
            //.ToList()
            //var response = _context.Dossiers.FromSqlRaw("EXECUTE gettDossierByIdSuup @id_sup", new SqlParameter("@id_sup", SupId)).ToList();
            var response = await _taskService.GetDossierById(SupId);
            if (response == null)
            {
                return NotFound(new { Message = "Dossier not found!" });
            }
            return Ok(new
            {
                dossier = response
            });
        }
       */

        [Route("ALLDossiers")]
        [HttpGet]
        public async Task<ActionResult> GetAllDossiers(Guid supId)
        {
            var response = await _taskService.GetAllDossiers(supId);

            if (response == null)
            {
                return NotFound(new { Message = "Dossier not found!" });
            }
            return Ok(response);
            
                
            
        }

    }
    


    }

