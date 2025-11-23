using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Resources.DBHandlers.CategoryDBHandler
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string _conn;

        public CategoryRepository(string conn)
        {
            _conn = conn;
        }

        public void Add(int walletId, string categoryName, CategoryType categoryType, string mieuTa)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Categories (WalletID, Name, Type, Description) " +
                                            "VALUES (@walletID, @name, @type, @desc)", conn);
            cmd.Parameters.AddWithValue("@walletID", walletId);
            cmd.Parameters.AddWithValue("@name", categoryName);
            cmd.Parameters.AddWithValue("@type", categoryType);
            cmd.Parameters.AddWithValue("@desc", mieuTa);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int categoryId)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE Id = @id",
                                            conn);
            cmd.Parameters.AddWithValue("id", categoryId);
        }

        public Category Get(int walletId, int categoryId)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories WHERE WalletID=@walletID AND Id=@catID", conn);
            cmd.Parameters.AddWithValue("@walletID", walletId);
            cmd.Parameters.AddWithValue("@catID", categoryId);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int walletid = Convert.ToInt32(reader["WalletID"]);
                string name = reader["Name"].ToString();
                CategoryType type = (CategoryType)reader["Type"];
                string description = reader["Description"].ToString();

                return new Category(id, walletid, name, type, description);
            }

            return null;
        }

        public List<Category> GetAll(int walletId)
        {
            List<Category> category_list = new List<Category>();

            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories WHERE WalletID=@walletID ORDER BY Type", conn);
            cmd.Parameters.AddWithValue("@walletID", walletId);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int walletid = Convert.ToInt32(reader["WalletID"]);
                string name = reader["Name"].ToString();
                CategoryType type = (CategoryType)reader["Type"];
                string description = reader["Description"].ToString();

                category_list.Add(new Category(id, walletid, name, type, description));
            }

            return category_list;
        }

        public List<Category> GetAllByType(int walletId, CategoryType categoryType)
        {
            List<Category> category_list = new List<Category>();

            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories WHERE WalletID=@walletID AND Type=@type ORDER BY Id", conn);
            cmd.Parameters.AddWithValue("@walletID", walletId);
            cmd.Parameters.AddWithValue("@type", categoryType);

            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                int walletid = Convert.ToInt32(reader["WalletID"]);
                string name = reader["Name"].ToString();
                CategoryType type = (CategoryType)reader["Type"];
                string description = reader["Description"].ToString();

                category_list.Add(new Category(id, walletid, name, type, description));
            }

            return category_list;
        }

        public void Update(int categoryId, string newName, string newMieuTa)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Categories SET Name=@name, Description=@d WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@name", newName);
            cmd.Parameters.AddWithValue("@d", newMieuTa);
            cmd.Parameters.AddWithValue("@id", categoryId);

            cmd.ExecuteNonQuery();
        }
    }
}
