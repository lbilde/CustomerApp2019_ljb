namespace Awesome_Larsness.CustomerApp2019.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address
        {
            get;
            set;
        }
    }
}