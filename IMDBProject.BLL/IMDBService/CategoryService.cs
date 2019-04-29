using IMDBProject.DAL.RepositoryConcrete;
using IMDBProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBProject.BLL.IMDBService
{
    public class CategoryService
    {
        CategoryRepository _categoryRepository;
        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }
        public int AddCategoryService(Category category)
        {
            try
            {
                return _categoryRepository.AddItem(category);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: "+e.Message);
                return 0;
            }
        }
        public int DeleteCategoryService(Category category)
        {
            try
            {
                return _categoryRepository.DeleteItem(category);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata: " + e.Message);
                return 0;
            }
        }

        public List<Category> GetAllCategoriesService()
        {
            return _categoryRepository.GetAll().ToList();
        }

        public Category GetByIdCategoryService(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public int UpdateCategoryService(Category category)
        {
            return _categoryRepository.UpdateItem(category);
        }
    }
}
