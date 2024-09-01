using CQRS_lib.Data;
using CQRS_lib.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_lib.Repo
{
    public class ItemsRepo : IItems
    {

        private  App_Db_Context _db;
        public ItemsRepo( App_Db_Context _Context)
        {
            _db = _Context;
        }

        public int DeleteItem(int id)
        {
            throw new NotImplementedException(); 
        }

        public Items GetItem(int id)
        {
            var item = _db.Items.SingleOrDefault(x => x.Id == id);
            return item ?? new();
        }

        public List<Items> GetItems()  => _db.Items.ToList();
       

        public int InsertItem(Items item)
        {
            _db.Items.Add(item);
            return _db.SaveChanges();
            
        }

        public int UpdateItem(Items item)
        {
            throw new NotImplementedException();
        }
    }
}
