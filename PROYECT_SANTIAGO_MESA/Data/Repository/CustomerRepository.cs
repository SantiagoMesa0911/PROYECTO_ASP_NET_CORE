

namespace PROYECT_SANTIAGO_MESA.Data.Repository
{
    using PROYECT_SANTIAGO_MESA.Core.Entity;
    using PROYECT_SANTIAGO_MESA.Core.Interfaces;
    using PROYECT_SANTIAGO_MESA.Data.AppDataContext;
    using PROYECT_SANTIAGO_MESA.Data.Repository.Base;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class CustomerRepository : BaseRepository<CustomerModel>, ICustomerRepository
    {
        public CustomerRepository(InvoiceDbContext context) : base(context)
        {
        }

        public IEnumerable<SelectListItem> GetAllForDropDown()
        {
            return All().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }
    }

}
