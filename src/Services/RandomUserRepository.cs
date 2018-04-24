using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using tinywebapp.Models;

namespace tinywebapp.Services {
    public class RandomUserRepository : IContactRepository
    {
        readonly HttpClient _httpClient;
        private const string api = "/api/?exc=login";

        public RandomUserRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://randomuser.me");
        }

        public async Task<Contact> GetContact(Id id)
        {
            var result = await _httpClient.GetStringAsync(api);            
            return Contact.FromJson(result).Results[0];
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            var result = await _httpClient.GetStringAsync(api);
           
            var contacts = Contact.FromJson(result);
            var tmp = new List<Contact>(contacts.Results);
            return tmp;
        }
    }
}