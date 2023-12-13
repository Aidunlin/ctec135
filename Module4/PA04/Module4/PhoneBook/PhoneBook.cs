/*
 * Name: Aidan Linerud
 * Date: 10/18/2023
 * Assignment: PA04
 */

namespace PhoneBook
{
    class PhoneBook
    {
        #region Fields

        /// <summary>
        /// The list of entities in this phonebook.
        /// </summary>
        private Entity[] entities;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new phonebook with 10 empty (null) entities.
        /// </summary>
        public PhoneBook()
        {
            entities = new Entity[10];
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds an entity to the first empty (null) element in this phonebook.
        /// If there are no empty elements, an error message is printed.
        /// </summary>
        public void AddEntity(Entity entity)
        {            
            for (int i = 0; i < entities.Length; i++)
            {
                if (entities[i] == null)
                {
                    entities[i] = entity;
                    return;
                }
            }

            Console.WriteLine("\tPhonebook is full; could not add an entity");
        }

        /// <summary>
        /// Creates and adds a new business to this phonebook.
        /// If there are no empty elements, an error message is printed.
        /// </summary>
        public void AddBusinessEntity
        (
            string address,
            string city,
            string state,
            string zip,
            string phoneNumber,
            string name
        )
        {
            Business business = new Business
            (
                address,
                city,
                state,
                zip,
                phoneNumber,
                name
            );

            AddEntity(business);
        }

        /// <summary>
        /// Creates and adds a new person to this phonebook.
        /// If there are no empty elements, an error message is printed.
        /// </summary>
        public void AddPersonEntity
        (
            string address,
            string city,
            string state,
            string zip,
            string phoneNumber,
            string firstName,
            string lastName
        )
        {
            Person person = new Person
            (
                address,
                city,
                state,
                zip,
                phoneNumber,
                firstName,
                lastName
            );

            AddEntity(person);
        }

        /// <summary>
        /// Prints each entity in this phonebook.
        /// </summary>
        public void PrintPhoneBook()
        {
            foreach (Entity entity in entities)
            {
                if (entity != null)
                {
                    entity.PrintEntity();
                }
            }
        }

        /// <summary>
        /// Prints entities in this phonebook that start with the given string.
        /// For businesses, the name is checked.
        /// For persons, the last name is checked.
        /// All strings are checked after converting to lower-case.
        /// If no entities are found, an error message is printed.
        /// </summary>
        public void Search(string str)
        {
            string strLowered = str.ToLower();
            bool found = false;

            foreach (Entity entity in entities)
            {
                if (entity == null)
                {
                    continue;
                }

                if (entity is Business business)
                {
                    if (business.Name.ToLower().StartsWith(strLowered))
                    {
                        found = true;
                        business.PrintEntity();
                    }
                }

                if (entity is Person person)
                {
                    if (person.LastName.ToLower().StartsWith(strLowered))
                    {
                        found = true;
                        person.PrintEntity();
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"\tPhone book does not contain: {str}");
                Console.WriteLine();
            }
        }

        #endregion
    }
}
