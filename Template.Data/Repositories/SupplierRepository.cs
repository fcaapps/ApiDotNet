using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Interfaces;
using Template.Data.Repositories;
using Template.Data.Context;
using Template.Domain.Entities;

namespace Template.Data.Repositories
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {

        public SupplierRepository(TemplateContext context)
            : base(context) { }

        public IEnumerable<Supplier> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }

    }

}
