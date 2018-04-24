using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using tinywebapp.Models;

namespace tinywebapp.Services {
    public class RandomUserRepository : IContactRepository
    {
        readonly HttpClient _httpClient;

        public RandomUserRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Contact> GetContact(Id id)
        {
            var result = await _httpClient.GetStringAsync("https://randomuser.me/api/");            
            return Contact.FromJson(result).Results[0];
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            var result = await _httpClient.GetStringAsync("https://randomuser.me/api/");
           
            var contacts = Contact.FromJson(result);
            var tmp = new List<Contact>(contacts.Results);
            return tmp;
        }
    }
}