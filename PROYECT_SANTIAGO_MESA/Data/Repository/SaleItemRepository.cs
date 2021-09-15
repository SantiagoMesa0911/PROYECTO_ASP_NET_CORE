using PROYECT_SANTIAGO_MESA.Core.Entity;
using PROYECT_SANTIAGO_MESA.Core.Interfaces;
using PROYECT_SANTIAGO_MESA.Data.AppDataContext;
using PROYECT_SANTIAGO_MESA.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceOne.Data.Repository
{
    public class SaleItemRepository : BaseRepository<SalesItemsModel>, ISaleItemRepository
    {
        public SaleItemRepository(InvoiceDbContext context) : base(context)
        {
        }
    }

}
