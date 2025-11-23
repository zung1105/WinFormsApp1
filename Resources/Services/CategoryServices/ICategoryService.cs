using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services.CategoryServices
{
    public interface ICategoryService
    {
        void AddNewCategory(Wallet wallet, Category newCategory);
        void Delete(Category categoryToDel);
        void Update(Category categoryToUpdate, string newName, string newMieuTa);
        Category Get(Wallet wallet, int categoryId);
        List<Category> GetAllByType(Wallet wallet, CategoryType categoryType);
        List<Category> GetAll(Wallet wallet);
    }
}
