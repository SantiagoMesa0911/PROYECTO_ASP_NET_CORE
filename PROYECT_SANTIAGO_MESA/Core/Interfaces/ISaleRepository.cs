using PROYECT_SANTIAGO_MESA.Core.Interfaces.Base;
using PROYECT_SANTIAGO_MESA.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Core
{
    public interface ISaleRepository : IBaseRepository<SalesModel>
    {
        void UpdatePlusStock(int productId, int stock);
        void UpdateMinusStock(int productId, int stock);
    }

}
