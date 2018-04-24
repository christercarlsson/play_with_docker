using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tinywebapp.Models;
using tinywebapp.Services;

namespace tinywebapp.Pages
{
    public class ContactModel : PageModel
    {
        private readonly IContactRepository _repository;

        public string Message { get; set; }
        public Contact Contact {get; private set;}
        public ContactModel(IContactRepository repository)
        {
            _repository = repository;
        }
        public void OnGet()
        {
            var contact = _repository.GetContacts();
            Message = "Your contact page.";
            Contact = contact.FirstOrDefault();
        
        }
    }
}
