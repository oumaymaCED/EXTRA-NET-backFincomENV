using Abp.Domain.Uow;
using AutoMapper;
using Business.Layer.DTO;
using Business.Layer.services.Contracts;
using DataAccess.Layer.Models;
using DataAccess.Layer.repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.services
{
    internal class SupplierService : IGenericSupplierService
    {
        private readonly IgenericSupRepository _taskRepository;
        private readonly IMapper _mapper;
         private IUnitOfWork _unitOfWork;

    public SupplierService(IgenericSupRepository taskRepository, IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }
    public SupplierService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

        // Configuration de mappage
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<Supplier, SupplierDto>();
        });

        // Créer un objet de mappage
        // _mapper = new Mapper(config);
        var mapper = config.CreateMapper();
    }

   

        public async Task<SupplierDto> GetSupplierById(Guid SupId)
        {
            var task = _taskRepository.GetSupplierById(SupId);
            return _mapper.Map<SupplierDto>(task);

        }
}
}


