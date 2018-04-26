using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using taskNortal.Shared;

namespace taskNortal.Models
{
    public class PhonesContext : DbContext
    {
        public PhonesContext() : base("PhonesDatabase")
        {
            Database.SetInitializer<PhonesContext>(new PhonesInitializer<PhonesContext>());
        }

        public DbSet<Phone> dbSet { get; set; }

        private class PhonesInitializer<T> : DropCreateDatabaseIfModelChanges<PhonesContext>
        {
            protected override void Seed(PhonesContext context)
            {
                SeedSqlFromJson seed = new SeedSqlFromJson();
                var list =  seed.GetDeserializedJsonFile();


                foreach (Phone ph in list)
                    context.dbSet.Add(ph);

                base.Seed(context);
            }
        }
    }
}