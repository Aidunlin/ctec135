/*
 * Name: Aidan Linerud
 * Date: 10/18/2023
 * Assignment: PA04
 */

namespace PhoneBook
{
    class Address
    {
        #region Properties
        
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        #endregion

        #region Constructor

        public Address(string address, string city, string state, string zip)
        {
            StreetAddress = address;
            City = city;
            State = state;
            Zip = zip;
        }

        #endregion

        #region Methods

        public void PrintAddress()
        {
            Console.WriteLine(StreetAddress);
            Console.WriteLine($"{City}, {State} {Zip}");
            Console.WriteLine();
        }

        #endregion
    }
}
