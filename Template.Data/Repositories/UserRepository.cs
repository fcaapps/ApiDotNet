using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Interfaces;
using Template.Data.Repositories;
using Template.Data.Content;
using Template.Domain.Entities;

namespace Template.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(TemplateContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }

    }

}
