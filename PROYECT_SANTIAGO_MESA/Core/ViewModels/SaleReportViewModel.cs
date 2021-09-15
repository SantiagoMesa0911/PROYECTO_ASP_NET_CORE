using System;
using System.Collections.Generic;
using PROYECT_SANTIAGO_MESA.Core.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Core.ViewModels
{
    public class SaleReportViewModel
    {
        public StoreSettingModel company { get; set; }
        public SalesModel Sales { get; set; }
    }

}
