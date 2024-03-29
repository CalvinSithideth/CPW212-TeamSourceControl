﻿using System;
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
        /// Returns all Firearms registered in the database
        /// </summary>
        /// <returns></returns>
        public static List<Firearms> GetFirearms()
        {
            //Creates the instance of the DB contexte
            //var db = new SimpleGunShopDatabaseEntities();

            using (SimpleGunShopDatabaseEntities context = new SimpleGunShopDatabaseEntities())
            {
                //This should allow the list to be grouped by manufacturer rather than showing duplicates

                //Using LINQ Method Syntax (returning all firearms in the database.
                //List<Firearms> firearms = context.Firearms.ToList();
                return context
                    .Firearms
                    .OrderBy(f => f.Manufacturer)
                    .ToList();
            }
        }

        /// <summary>
        /// Adds a Firearm. Returns the newly added Firearm
        /// with the FirearmID populated
        /// </summary>
        /// <param name="firearm">The Firearm to add.</param>
        /// <returns></returns>
        public static Firearms AddFirearm(Firearms firearm)
        {
            using (var context = new SimpleGunShopDatabaseEntities())
            {
                context.Firearms.Add(firearm);
                context.SaveChanges();
                context.Entry(firearm).State = EntityState.Added; // Tell EF firearm has been added
                return firearm;
            }
        }

        /// <summary>
        /// Updates a Firearm in the Database.
        /// Returns the updated Firearm.
        /// </summary>
        /// <param name="firearm">The Firearm to update.</param>
        /// <returns></returns>
        public static Firearms UpdateFirearm(Firearms firearm)
        {
            using (var context = new SimpleGunShopDatabaseEntities())
            {
                try
                {
                    context.Firearms.Add(firearm);
                    context.Entry(firearm).State = EntityState.Modified; // Tell EF it has been modified
                    context.SaveChanges();
                    return firearm;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach(var validationError in validationErrors.ValidationErrors)
                            {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);

                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
                
            }
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
