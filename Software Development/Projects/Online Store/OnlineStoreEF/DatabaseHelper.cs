using OnlineStoreEFCoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreEFCoreProject
{
    public class DatabaseHelper
    {
        private readonly OnlineStoreSimeonContext context;

        public DatabaseHelper()
        {
            context = new OnlineStoreSimeonContext();
        }

        public List<T> GetAll<T>() where T : class
        {
            return context.Set<T>().ToList();
        }

        public T Get<T>(int id) where T : IIdentifiable
        {
            return context.Set<T>().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Add<T>(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
    }
}
