using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnroidApi.Models.Data
{
    public class BaseRepository
    {
        public AndAuEntities _db;

        public BaseRepository()
        {
            this._db = new AndAuEntities();
        }


    }
}