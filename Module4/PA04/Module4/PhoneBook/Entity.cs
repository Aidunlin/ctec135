/*
 * Name: Aidan Linerud
 * Date: 10/18/2023
 * Assignment: PA04
 */

namespace PhoneBook
{
    abstract class Entity
    {
        #region Properties

        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        #endregion

        #region Constructor

        public Entity
        (
            string address,
            string city,
            string state,
            string zip,
            string phoneNumber
        )
        {
            Address = new Address(address, city, state, zip);
            PhoneNumber = phoneNumber;
        }

        #endregion

        #region Methods

        public abstract void PrintEntity();

        #endregion
    }

    class Business : Entity
    {
        #region Properties

        public string Name { get; set; }

        #endregion

        #region Constructor

        public Business
        (
            string address,
            string city,
            string state,
            string zip,
            string phoneNumber,
            string name
        )
        : base(address, city, state, zip, phoneNumber)
        {
            Name = name;
        }

        #endregion

        #region Methods

        public override void PrintEntity()
        {
            Console.WriteLine(Name);
            Address.PrintAddress();
        }

        #endregion
    }

    class Person : Entity
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region Constructor

        public Person
        (
            string address,
            string city,
            string state,
            string zip,
            string phoneNumber,
            string firstName,
            string lastName
        )
        : base(address, city, state, zip, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        #endregion

        #region Methods

        public override void PrintEntity()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Address.PrintAddress();
        }

        #endregion
    }
}
