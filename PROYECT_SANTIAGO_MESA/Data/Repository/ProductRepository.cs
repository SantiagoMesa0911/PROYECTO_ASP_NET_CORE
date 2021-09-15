using PROYECT_SANTIAGO_MESA.Core;
using PROYECT_SANTIAGO_MESA.Core.Interfaces;
using PROYECT_SANTIAGO_MESA.Data.AppDataContext;
using PROYECT_SANTIAGO_MESA.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Data.Repository
{
    public class ProductRepository : BaseRepository<ProductModel>, IProductRepository
    {
        public ProductRepository(InvoiceDbContext context) : base(context)
        {
        }
    }

}
