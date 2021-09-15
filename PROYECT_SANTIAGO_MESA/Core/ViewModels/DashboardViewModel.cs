using PROYECT_SANTIAGO_MESA.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Core.ViewModels
{
    public class DashboardViewModel
    {
        public int Customers { get; set; }
        public int Products { get; set; }
        public double TotalSaleValue { get; set; }
        public int TotalSales { get; set; }
        public List<SalesModel> LastFiveSales { get; set; }

    }
}
