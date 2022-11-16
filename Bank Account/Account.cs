
namespace Bank_Account
{
    internal class Account
    {
        private decimal _balance;

        /// <summary>
        /// See the money
        /// </summary>
        public decimal GetBalance()
        {
            return _balance;
        }

        /// <summary>
        /// Put in
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        /// <summary>
        /// Take out
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}
