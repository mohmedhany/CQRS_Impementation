﻿using CQRS_lib.Data.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_lib.Repo
{
    public interface IItems
    {
    
        public List<Items> GetItems();
        public Items GetItem(int id);
        public int InsertItem(Items item);
        public int UpdateItem(Items item);
        public int DeleteItem(int id);
    
    }
}
