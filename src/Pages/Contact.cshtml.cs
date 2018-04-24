using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tinywebapp.Models;
using tinywebapp.Services;

namespace tinywebapp.Pages
{
    public class ContactModel : PageModel
    {
        private readonly IContactRepository _repository;
        public Contact Contact {get; private set;} 
        public ContactModel(IContactRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
            try {
            var contacts = Task.Run( () => _repository.GetContacts());
            Contact = contacts.Result.FirstOrDefault();
            }
            catch {
                RedirectToPage("Error.cshtml");
            }
        }
    }
}
