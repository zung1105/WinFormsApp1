namespace WinFormsApp1.Models
{
    public class Wallet
    {
        public int Id { get; private set; }
        public decimal CurrentBallance { get; private set; } = decimal.Zero;
        public string Name {  get; private set; }
        public DateTime CreatedAt {  get; private set; } = DateTime.Now;
        public string Description { get; private set; } = string.Empty;

        public bool CurBallanceIsPositive => CurrentBallance >= 0;
        public Wallet(int id, string name, decimal cur_bal, string description, DateTime createdAt)
        {
            if(id <= 0)
            {
                throw new ArgumentNullException("Cannot CREATE Wallet with ID less or equal 0");
            }

            Id = id;
            CurrentBallance = cur_bal;
            SetName(name);
            CreatedAt = createdAt;
            Description = description;
        }

        public Wallet(string name, decimal soDuBanDau, string mieuTa)
        {
            SetName(name);
            this.CurrentBallance = soDuBanDau;
            this.Description = mieuTa;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Cannot CREATE Wallet with NAME is NULL or EMPTY");
            }

            this.Name = name;
        }
    }


}
