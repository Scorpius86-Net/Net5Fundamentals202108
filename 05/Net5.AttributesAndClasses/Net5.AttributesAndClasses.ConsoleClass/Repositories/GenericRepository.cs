using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass.Repositories
{
    public class GenericRepository<TEntity>
    {   public List<TEntity> _items { get; set; }

        public GenericRepository()
        {
            _items = new List<TEntity>();
        }
        public void Insert(TEntity item)
        {
            _items.Add(item);
        }
        public void Delete(TEntity item)
        {
            _items.Remove(item);
        }
        public void Update(TEntity oldItem, TEntity newItem)
        {
            _items.Remove(oldItem);
            _items.Add(newItem);
        }
        public List<TEntity> List()
        {
            return _items;
        }
    }
}
