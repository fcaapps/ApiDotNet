using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.ViewModels;
using Template.Domain.Entities;

namespace Template.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<UserViewModel, User>();
            CreateMap<SupplierViewModel, Supplier>();

            #endregion

            #region DomainToViewModel

            CreateMap<Supplier, SupplierViewModel>();

            #endregion
        }
    }
}