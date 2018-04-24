using System.Collections.Generic;
using System.Threading.Tasks;
using tinywebapp.Models;

namespace tinywebapp.Services {
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetContacts();
        Task<Contact> GetContact(Id id);
    }
}