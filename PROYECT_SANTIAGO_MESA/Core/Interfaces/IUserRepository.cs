using PROYECT_SANTIAGO_MESA.Core.Interfaces.Base;
using PROYECT_SANTIAGO_MESA.Core.Entity;
using PROYECT_SANTIAGO_MESA.Core.Entity.Base;
using PROYECT_SANTIAGO_MESA.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Core.Interfaces
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        bool ValidateUser(LoginViewModel user);
    }

}
