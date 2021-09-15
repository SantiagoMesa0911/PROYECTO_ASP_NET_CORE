using PROYECT_SANTIAGO_MESA.Core.Entity;
using PROYECT_SANTIAGO_MESA.Core.Interfaces;
using PROYECT_SANTIAGO_MESA.Core.ViewModels;
using PROYECT_SANTIAGO_MESA.Data.AppDataContext;
using PROYECT_SANTIAGO_MESA.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Data.Repository
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(InvoiceDbContext context) : base(context)
        {
        }

        public bool ValidateUser(LoginViewModel user)
        {
            return All().Any(x => x.Email == user.Email && x.Password == user.Password);
        }
    }

}
