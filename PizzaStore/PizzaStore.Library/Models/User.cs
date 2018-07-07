using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Library.Interfaces;

namespace PizzaStore.Library.Models
{
    public class User : Order, IUser
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string userID;
        private string defaultLocation;
        private DateTime lastTimeOrdered;
        public Order lastThingsOrder;

        public string FirstName
        {
            get => firstName;
            set
            {
                // "value" is the value passed to the setter.
                if (value.Length == 0)
                {
                    // good practice to provide useful messages when throwing exceptions,
                    // as well as the name of the relevant parameter if applicable.
                    throw new ArgumentException("First Name must not be empty.", nameof(value));
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                // "value" is the value passed to the setter.
                if (value.Length == 0)
                {
                    // good practice to provide useful messages when throwing exceptions,
                    // as well as the name of the relevant parameter if applicable.
                    throw new ArgumentException("Last Name must not be empty.", nameof(value));
                }
                lastName = value;
            }
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                // "value" is the value passed to the setter.
                if (value.Length == 0)
                {
                    // good practice to provide useful messages when throwing exceptions,
                    // as well as the name of the relevant parameter if applicable.
                    throw new ArgumentException("Phone Number must not be empty.", nameof(value));
                }
                phoneNumber = value;
            }
        }

        public string UserID
        {
            get => userID;

            set
            {
                // "value" is the value passed to the setter.
                if (value.Length == 0)
                {
                    // good practice to provide useful messages when throwing exceptions,
                    // as well as the name of the relevant parameter if applicable.
                    throw new ArgumentException("User ID must not be empty.", nameof(value));
                }
                userID = value;
            }
        }

        public string DefaultLocation
        {
            get => defaultLocation;
            set
            {
                // "value" is the value passed to the setter.
                if (value.Length == 0)
                {
                    // good practice to provide useful messages when throwing exceptions,
                    // as well as the name of the relevant parameter if applicable.
                    throw new ArgumentException("Location must not be empty.", nameof(value));
                }
                defaultLocation = value;
            }
        }

        public DateTime LastTimeOrdered
        {
            get => lastTimeOrdered;
            set
            {
                if(value!=null)
                {
                    lastTimeOrdered = value;

                }
         
            }
        }
    }
    }
}
