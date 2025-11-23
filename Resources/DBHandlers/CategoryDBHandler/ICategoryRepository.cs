using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Resources.DBHandlers.CategoryDBHandler
{
    public interface ICategoryRepository
    {
        void Add(int walletId, string categoryName, CategoryType categoryType, string mieuTa);
        void Delete(int categoryId);
        void Update(int categoryId, string newName, string newMieuTa);
        Category Get(int walletId, int categoryId);
        List<Category> GetAllByType(int walletId, CategoryType categoryType);
        List<Category> GetAll(int walletId);
    }
}
