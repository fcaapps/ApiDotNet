using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.ViewModels;

namespace Template.Application.Interfaces
{
    public interface ISupplierService
    {
        List<SupplierViewModel> Get();
        bool Post(SupplierViewModel supplierViewModel);
        SupplierViewModel GetById(string id);
        bool Put(SupplierViewModel supplierViewModel);
        bool Delete(string id);

    }
}
