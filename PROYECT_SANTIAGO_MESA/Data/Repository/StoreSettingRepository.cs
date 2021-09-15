

namespace PROYECT_SANTIAGO_MESA.Data.Repository
{
    using PROYECT_SANTIAGO_MESA.Core.Entity;
    using PROYECT_SANTIAGO_MESA.Core.Interfaces;
    using PROYECT_SANTIAGO_MESA.Data.AppDataContext;
    using PROYECT_SANTIAGO_MESA.Data.Repository.Base;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class StoreSettingRepository : BaseRepository<StoreSettingModel>, IStoreSettingRepository
    {
        public StoreSettingRepository(InvoiceDbContext context) : base(context)
        {
        }
    }

}
