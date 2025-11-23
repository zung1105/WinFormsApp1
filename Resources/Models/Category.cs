
public enum CategoryType
{
    ChiTieu,
    ThuNhap
}

namespace WinFormsApp1.Models
{
    public class Category
    {
        public int Id { get; private set; }
        public int WalletId {  get; private set; }
        public string Name { get; private set; }
        public CategoryType Type { get; private set; }
        public string Description { get; private set; }

        public Category(int id, int walletId, string name, CategoryType type, string description)
        {
            Id = id;
            WalletId = walletId;
            SetName(name);
            Type = type;
            Description = description;
        }

        public Category(int walletId, string newName, CategoryType type, string description)
        {
            WalletId = walletId;
            SetName(newName);
            Type = type;
            Description = description;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("CATEGORY: with NAME is NULL or EMPTY");
            }

            Name = name;    
        }
    }
}
