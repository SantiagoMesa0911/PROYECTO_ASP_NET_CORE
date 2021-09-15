using PROYECT_SANTIAGO_MESA.Core.Entity;
using PROYECT_SANTIAGO_MESA.Core.Interfaces.Base;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Core.Interfaces
{
    public interface ICustomerRepository : IBaseRepository<CustomerModel>
    {
        IEnumerable<SelectListItem> GetAllForDropDown();
    }

}
