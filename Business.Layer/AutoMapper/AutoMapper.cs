using AutoMapper;
using Business.Layer.DTO;
using Business.Layer.services;
using DataAccess.Layer.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
           
            CreateMap<DossierDto, Dossier>();
           
            CreateMap<DataAccess.Layer.Models.Dossier, Business.Layer.DTO.DossierDto>();
            
            //CreateMap<IEnumerable<Dossier>>, List<Dossier>>();

            //CreateMap<IEnumerable<Dossier>, List<DossierDto>>();
            //CreateMap<List<DossierDto>, IEnumerable<Dossier>>();

            //CreateMap<Task<DataAccess.Layer.Models.Dossier>, Business.Layer.DTO.DossierDto>().ConvertUsing<DossierService>();
            CreateMap<SupplierDto, Supplier>();
            CreateMap<Supplier, SupplierDto>();


            //CreateMap<DataAccess.Layer.Models.Supplier, Business.Layer.DTO.SupplierDto>();
            CreateMap<SalesInvoiceDto, SalesInvoice>();
            CreateMap<SalesInvoice, SalesInvoiceDto>();
        }
    }
}
