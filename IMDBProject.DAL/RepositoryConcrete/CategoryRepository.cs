using IMDBProject.DAL.IMDBContextFile;
using IMDBProject.DAL.RepositoryAbstract;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBProject.DAL.RepositoryConcrete
{
    public class CategoryRepository : ICategoryRepository
    {
        IMDBContext _db = DbInstance.Instance;
        int _etkilenenSatir;
        public CategoryRepository()
        {
        }
        public int AddItem(Category item)
        {
            //using(IMDBContext _db=new IMDBContext())
            {
                _db.Category.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
            
        }

        public int DeleteItem(Category item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                _db.Category.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<Category> GetAll()
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Category.ToList();
            }
        }

        public Category GetById(int id)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                return _db.Category.Where(x => x.CategoryID == id).FirstOrDefault();
            }
        }

        public int UpdateItem(Category item)
        {
            //using (IMDBContext _db = new IMDBContext())
            {
                Category lastCategory = _db.Category.Where(x => x.CategoryID == item.CategoryID).FirstOrDefault();
                lastCategory.CategoryName = item.CategoryName;
                lastCategory.UpdateDate = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
