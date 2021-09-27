using PROYECT_SANTIAGO_MESA.Core;
using PROYECT_SANTIAGO_MESA.Core.Entity;
using PROYECT_SANTIAGO_MESA.Core.Interfaces;
using PROYECT_SANTIAGO_MESA.Data.AppDataContext;
using PROYECT_SANTIAGO_MESA.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Data.Repository
{
    public class SaleRepository : BaseRepository<SalesModel>, ISaleRepository
    {
        private readonly InvoiceDbContext context;

        public SaleRepository(InvoiceDbContext context) : base(context)
        {
            this.context = context;
        }

        public void UpdatePlusStock(int productId, int stock)
        {
            var product = context.Products.Find(productId);
            product.Stock = product.Stock + stock;
            context.SaveChanges();
        }
        public void UpdateMinusStock(int productId, int stock)
        {
            var product = context.Products.Find(productId);
            product.Stock = product.Stock - stock;
            context.SaveChanges();
        }
    }

}
