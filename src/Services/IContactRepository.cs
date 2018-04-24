using System.Collections.Generic;
using tinywebapp.Models;

namespace tinywebapp.Services {
    public interface IContactRepository
    {
        IEnumerable<Contact> GetContacts();
        Contact GetContact(Id id);
    }
}