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

        public void CreateWare(Ware w)
        {
            using (WaresDBEntities db = new WaresDBEntities())
            {
                w.Id = db.Wares.ToList().LastOrDefault().Id + 1;
                db.Wares.Add(w);
                db.SaveChanges();
            }
        }

        public List<Ware> ShowAllWares()
        {
            using(WaresDBEntities db = new WaresDBEntities())
            {
                var wares = db.Wares.ToList();
                return wares;
            }
        }
    }
}
