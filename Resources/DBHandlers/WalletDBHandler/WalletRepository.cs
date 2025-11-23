using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.Resources.DBHandlers.WalletDBHandler
{
    public class WalletRepository : IWalletRepository
    {
        private readonly string _conn;

        public WalletRepository(string connectionString)
        {
            _conn = connectionString;
        }

        public int Add(string name, decimal soDuBanDau, string mieuTa)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Wallet (Name, Balance, Description) VALUES (@name, @balance, @desc)", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@balance", soDuBanDau);
            cmd.Parameters.AddWithValue("@desc", mieuTa);

            return cmd.ExecuteNonQuery();
        }

        public int Delete(int id)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Wallet WHERE Id = @id", 
                                            conn);
            cmd.Parameters.AddWithValue("id", id);

            return cmd.ExecuteNonQuery();
        }

        public List<Wallet> GetAll()
        {
            List<Wallet> allWallet = new List<Wallet>();

            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Wallet ORDER BY Id", conn);

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["Name"].ToString();
                decimal cur_balance = (decimal)reader["Balance"];
                string description = reader["Description"].ToString();
                DateTime createdAt = (DateTime)reader["CreatedAt"];

                allWallet.Add(new Wallet(id, name, cur_balance, description, createdAt));
            }

            return allWallet;
        }

        public Wallet GetWallet(int id)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Wallet WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()){
                int walletid = Convert.ToInt32(reader["Id"]);
                string name = reader["Name"].ToString();
                decimal cur_balance = (decimal)reader["Balance"];
                string description = reader["Description"].ToString();
                DateTime createdAt = (DateTime)reader["CreatedAt"];

                return new Wallet(walletid, name, cur_balance, description, createdAt);
            }

            return null;
        }

        public int Update(int id, string name, string mieuTa, DateTime createdAt)
        {
            using SqlConnection conn = new SqlConnection(_conn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Wallet SET Name=@name, Description=@d, CreatedAt=@date WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@d", mieuTa);
            cmd.Parameters.AddWithValue("@date", createdAt);
            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery();
        }
    }
}
