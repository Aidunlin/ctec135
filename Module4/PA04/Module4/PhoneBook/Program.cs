/*
 * Name: Aidan Linerud
 * Date: 10/18/2023
 * Assignment: PA04
 */

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region Test class constructors

            Console.WriteLine("Test Address class");
            Address address = new Address
            (
                "1234 First Street",
                "Vancouver",
                "WA",
                "12345"
            );
            address.PrintAddress();

            Console.WriteLine("Test Business class");
            Business business = new Business
            (
                "1234 First Street",
                "Vancouver",
                "WA",
                "12345",
                "123-456-7890",
                "FooBar LLC"
            );
            business.PrintEntity();

            Console.WriteLine("Test Person class");
            Person person = new Person
            (
                "1234 First Street",
                "Vancouver",
                "WA",
                "12345",
                "123-456-7890",
                "Joe",
                "Schmoe"
            );
            person.PrintEntity();

            #endregion

            Console.WriteLine();

            #region Test phonebook creation

            Console.WriteLine("Test phonebook");
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddBusinessEntity
            (
                "1234 First Street",
                "Vancouver",
                "WA",
                "12345",
                "123-456-7890",
                "FooBar LLC"
            );
            phoneBook.AddPersonEntity
            (
                "1234 First Street",
                "Vancouver",
                "WA",
                "12345",
                "123-456-7890",
                "Joe",
                "Schmoe"
            );
            phoneBook.PrintPhoneBook();

            #endregion

            Console.WriteLine();

            #region Test phonebook search

            Console.WriteLine("Phonebook Search tests");
            Console.WriteLine("search for foo");
            phoneBook.Search("foo");
            Console.WriteLine("search for Joe");
            phoneBook.Search("Joe");
            Console.WriteLine("search for Sch");
            phoneBook.Search("Sch");

            #endregion

            Console.WriteLine();
        }
    }
}
