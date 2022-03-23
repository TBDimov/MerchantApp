using MerchantApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantApp.Controller
{
    internal class WaresController
    {
        public List<Ware> GetAll()
        {
            using (WaresDBEntities db = new WaresDBEntities())
            {
                return db.Wares.ToList();
            }
        }
    }
}
