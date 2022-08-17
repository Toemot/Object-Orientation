using Acme.Common;

namespace ACM.BL
{
    public class Customer : BaseEntity, ILoggable
    {
        public Customer(): this(0) {}
        public Customer(int customerId)
        {
            CustomerId = customerId;
            Addresses = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public List<Address> Addresses { get; set; }
        public int CustomerType { get; set; }

        public override string ToString() => FirstName;

        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}