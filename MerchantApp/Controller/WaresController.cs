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
        public void DeleteWare(int id)
        {
            using (WaresDBEntities db = new WaresDBEntities())
            {

                var wareToDelete = db.Wares.Where(w => w.Id == id).FirstOrDefault();

                if (wareToDelete != null)
                {
                    db.Wares.Remove(wareToDelete);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateWare(int id, Ware ware)
        {
            using (WaresDBEntities db = new WaresDBEntities())
            {
                var wareToUpdate = db.Wares.Where(g => g.Id == id).FirstOrDefault();
                if (wareToUpdate != null)
                {
                    wareToUpdate.Price = ware.Price;
                    wareToUpdate.ItemName = ware.Item_Name;
                    wareToUpdate.ItemOrigin = ware.Item_Origin;
                    db.SaveChanges();
                }
            }
        }
    }
}
