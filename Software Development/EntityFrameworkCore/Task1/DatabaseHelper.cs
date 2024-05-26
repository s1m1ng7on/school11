using Microsoft.EntityFrameworkCore;
using Task1.Data;
using System.Reflection;

namespace Task1
{
    public class DatabaseHelper
    {
        private readonly Context context;

        public DatabaseHelper()
        {
            context = new Context();
        }

        public List<T> GetAll<T>() where T : class
        {
            DbSet<T> entities = context.Set<T>();
            TrimWhitespaces(entities);

            return entities.ToList();
        }
        public T Get<T>(int id) where T : class
        {
            var entity = context.Set<T>().Find(id);
            TrimWhitespaces(entity);

            return entity;
        }
        public void Add<T>(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        private void TrimWhitespaces<T>(DbSet<T> entities) where T : class
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (T entity in entities)
                TrimWhitespaces(entity, properties);
        }
        private void TrimWhitespaces<T>(T entity, PropertyInfo[] properties = null) where T : class
        {
            if (properties == null)
                properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(entity) is string propertyValue)
                    property.SetValue(entity, propertyValue.Trim());
            }
        }
    }
}