using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TestTask_Intetics_.Models
{
    public class Repository
    {
        public static IQueryable<TEntity> Select<TEntity>() where TEntity : class
        {
            EFDbContext db = new EFDbContext();
            return db.Set<TEntity>();
        }

        public static void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            EFDbContext db = new EFDbContext();

            db.Entry(entity).State = EntityState.Added;
            db.SaveChanges();
        }

        public static void Inserts<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            EFDbContext db = new EFDbContext();

            db.Configuration.AutoDetectChangesEnabled = false;
            db.Configuration.ValidateOnSaveEnabled = false;

            foreach (TEntity entity in entities)
            {
                db.Entry(entity).State = EntityState.Added;
            }
            db.SaveChanges();

            db.Configuration.AutoDetectChangesEnabled = true;
            db.Configuration.ValidateOnSaveEnabled = true;
        }

        public static void Update<TEntity>(TEntity entity, EFDbContext db) where TEntity : class
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            EFDbContext db = new EFDbContext();

            db.Entry(entity).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}