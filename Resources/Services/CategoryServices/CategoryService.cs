using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Resources.DBHandlers.CategoryDBHandler;
//using WinFormsApp1.Repositories.CategoryRepositoies;

namespace WinFormsApp1.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddNewCategory(Wallet wallet, Category newCategory)
        {
            if(newCategory == null)
            {
                throw new Exception("ADD NEW CATEGORY: Category is NULL");
            }

            if(wallet == null)
            {
                throw new Exception("ADD NEW CATEGORY: Wallet is NULL");
            }

            if(_categoryRepository == null)
            {
                throw new Exception("ADD NEW CATEGORY: Category Repo is NULL");
            }

            _categoryRepository.Add(wallet.Id, newCategory.Name, newCategory.Type, newCategory.Description);
        }

        public void Delete(Category categoryToDel)
        {
            if(categoryToDel == null)
            {
                throw new Exception("DELETE CATEGORY: Category is NULL");
            }

            if (_categoryRepository == null)
            {
                throw new Exception("DELETE CATEGORY: Category Repo is NULL");
            }

            _categoryRepository.Delete(categoryToDel.Id);
        }

        public Category Get(Wallet wallet, int categoryId)
        {
            if(_categoryRepository == null)
            {
                throw new Exception("GET CATEGORY: Category Repo is NULL");
            }

            if (wallet == null)
            {
                throw new Exception("GET CATEGORY: Wallet is NULL");
            }

            Category result = _categoryRepository.Get(wallet.Id, categoryId);
            
            if(result == null)
            {
                throw new Exception("GET CATEGORY: NULL RETURN");
            }

            return result;
        }

        public List<Category> GetAll(Wallet wallet)
        {
            if (_categoryRepository == null)
            {
                throw new Exception("GET ALL CATEGORY: Category Repo is NULL");
            }

            if (wallet == null)
            {
                throw new Exception("GET CATEGORY: Wallet is NULL");
            }

            return _categoryRepository.GetAll(wallet.Id);
        }

        public List<Category> GetAllByType(Wallet wallet, CategoryType categoryType)
        {
            if (_categoryRepository == null)
            {
                throw new Exception("GET ALL CATEGORY: Category Repo is NULL");
            }

            if (wallet == null)
            {
                throw new Exception("GET CATEGORY: Wallet is NULL");
            }

            return _categoryRepository.GetAllByType(wallet.Id, categoryType);
        }

        public void Update(Category categoryToUpdate, string newName, string newMieuTa)
        {
            if(categoryToUpdate == null)
            {
                throw new Exception("UPDATE CATEGORY: Category to UPDATE is NULL");
            }

            if(string.IsNullOrEmpty(newName))
            {
                throw new Exception("UPDATE CATEGORY: NEW NAME to UPDATE is EMPTY or NULL");
            }

            if (_categoryRepository == null)
            {
                throw new Exception("UPDATE CATEGORY: Category Repo is NULL");
            }

            _categoryRepository.Update(categoryToUpdate.Id, newName, newMieuTa);
        }
    }
}
