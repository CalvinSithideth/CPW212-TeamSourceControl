using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl
{
    /// <summary>
    /// A Database helper class for Firearms and the SimpleGunShopDatabase.
    /// </summary>
    static class FirearmDB
    {
        /// <summary>
        /// Returns all Firearms from the database
        /// </summary>
        /// <returns></returns>
        public static List<Firearms> GetFirearms()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a Firearm. Returns the newly added Firearm
        /// with the FirearmID populated
        /// </summary>
        /// <param name="firearm">The Firearm to add.</param>
        /// <returns></returns>
        public static Firearms AddFirearm(Firearms firearm)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a Firearm in the Database.
        /// Returns the updated Firearm.
        /// </summary>
        /// <param name="firearm">The Firearm to update.</param>
        /// <returns></returns>
        public static Firearms UpdateFirearm(Firearms firearm)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a Firearm from the Database.
        /// </summary>
        /// <param name="firearm"></param>
        public static void DeleteFirearm(Firearms firearm)
        {
            using (var context = new SimpleGunShopDatabaseEntities())
            {
                context.Firearms.Add(firearm); // Track with EF
                context.Entry(firearm).State = EntityState.Deleted; // Tell EF we are removing it
                context.SaveChanges(); // Update on DB
            }
        }
    }
}
