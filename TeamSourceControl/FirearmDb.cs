using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl
{
    static class FirearmDb
    {
        /// <summary>
        /// Returns all Firearms registered in the database
        /// </summary>
        /// <returns></returns>
        public static List<Firearms> GetFirearms()
        {
            //Creates the instance of the DB contexte
            var db = new SimpleGunShopDatabaseEntities();

            //Using LINQ Method Syntax (returning all firearms in the database.
            List<Firearms> firearms = db.Firearms.ToList();

            return firearms;
        }
    }
}
