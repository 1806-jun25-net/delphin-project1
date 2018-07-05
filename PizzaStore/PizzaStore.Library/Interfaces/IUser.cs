using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserID { get; set; } //probably going to set as "FirstNameLastName-DefaultLocation"
        string DefaultLocation { get; set; } // location usually ordered from
        string PhoneNumber { get; set; }
        DateTime LastTimeOrdered { get; set; } 

    }
}
