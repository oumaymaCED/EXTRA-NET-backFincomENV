using Abp.Domain.Uow;
using AutoMapper;
using Business.Layer.DTO;
using Business.Layer.services.Contracts;
using Business.Layer.AutoMapper;
using DataAccess.Layer.Models;
using DataAccess.Layer.repositories;
using DataAccess.Layer.repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.services
{
    public class DossierService : IGenericservice
    {
        private readonly IGenericRepository _taskRepository;
        private readonly IMapper _mapper;
        //private IUnitOfWork _unitOfWork;

        public DossierService(IGenericRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }
      

        public IEnumerable<DossierDto> GetAllDossiers()
        {
            throw new NotImplementedException();
        }



        public async Task<DossierDto> GetDossierById(Guid SupId)
        {
            var dossiers = _taskRepository.GetDossierById(SupId);
            return _mapper.Map<DossierDto>(dossiers);
        }

        public async Task<List<DossierDto>> GetAllDossiers(Guid SupId)
        {
            var dossiers =  _taskRepository.GetAllDossiers(SupId);
            var dossierDtos = _mapper.Map<List<DossierDto>>(dossiers);
            return dossierDtos;
        }
    }
}
