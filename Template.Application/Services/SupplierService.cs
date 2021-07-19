using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.Domain.Entities;
using Template.Domain.Interfaces;
using AutoMapper;

namespace Template.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;
        private readonly IMapper mapper;

        public SupplierService(ISupplierRepository supplierRepository, IMapper mapper)
        {
            this.supplierRepository = supplierRepository;
            this.mapper = mapper;
        }
        public List<SupplierViewModel> Get()
        {
            List<SupplierViewModel> _supplierViewModels = new List<SupplierViewModel>();

            IEnumerable<Supplier> _supplier = this.supplierRepository.GetAll();

            foreach (var item in _supplier)
            {
                _supplierViewModels.Add(new SupplierViewModel {
                    Id = item.Id, 
                    RazaoSocial = item.RazaoSocial, 
                    NomeFantasia = item.NomeFantasia,
                    Bairro = item.Bairro,
                    Cep = item.Cep,
                    Cnpj = item.Cnpj,
                    Complemento = item.Complemento,
                    Localidade = item.Localidade,
                    Numero = item.Numero
                });
            }

            return _supplierViewModels;
        }

       public bool Post(SupplierViewModel supplierViewModel)
        {

            Supplier _supplier = mapper.Map<Supplier>(supplierViewModel);

            this.supplierRepository.Create(_supplier);

            return true;

            
        }

        public SupplierViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid supplierId))
                throw new Exception("SupplierID is not valid");

            Supplier _supplier = this.supplierRepository.Find(x => x.Id == supplierId && !x.IsDeleted);
            if (_supplier == null)
                throw new Exception("Supplier not found");

            return mapper.Map<SupplierViewModel>(_supplier);
        }

        public bool Put(SupplierViewModel supplierViewModel)
        {
            if (supplierViewModel.Id == Guid.Empty)
                throw new Exception("ID is invalid");

            Supplier _supplier = this.supplierRepository.Find(x => x.Id == supplierViewModel.Id && !x.IsDeleted);
            if (_supplier == null)
                throw new Exception("Supplier not found");

            _supplier = mapper.Map<Supplier>(supplierViewModel);
            //_user.Password = EncryptPassword(_user.Password);

            this.supplierRepository.Update(_supplier);

            return true;
        }

        public bool Delete(string id)
        {
            if (!Guid.TryParse(id, out Guid supplierId))
                throw new Exception("SupplierID is not valid");

            Supplier _supplier = this.supplierRepository.Find(x => x.Id == supplierId && !x.IsDeleted);
            if (_supplier == null)
                throw new Exception("Supplier not found");

            return this.supplierRepository.Delete(_supplier);
        }

    }
}
