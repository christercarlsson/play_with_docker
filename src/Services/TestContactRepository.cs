using System.Collections.Generic;
using tinywebapp.Models;

namespace tinywebapp.Services {
    public class TestContactRepository : IContactRepository
    {
        public Contact GetContact(Id id)
        {
            return  new Contact {
                    Gender = "male",
                    Name = new Name {
                        Title = "Mr.",
                        First = "John",
                        Last = "Smith"
                    },
                    Location = new Location {
                        Street = "StubbleStreet 92",
                        City = "Mårtsbo",
                        State = "Sweden",
                        Postcode = 80286
                    },
                    Email = "john.smith@gmail.com",
                    Login = new Login {
                        Username = "jsmith",
                        Password = "73KgJv60WvE0",
                        Salt = "73KgJv60WvE0",
                        Md5 = "73KgJv60WvE0",
                        Sha1 = "73KgJv60WvE0",
                        Sha256 = "73KgJv60WvE0"
                    },
                    Dob = new System.DateTimeOffset(new System.DateTime(1987, 09, 12)),
                    Registered = new System.DateTimeOffset(new System.DateTime(2015,12,10)),
                    Phone = "",
                    Cell = "+4672143131",
                    Id = new Id {
                        Name = "BSN",
                        Value = "04242023"
                    },
                    Picture = new Picture {
                        Large = "https://randomuser.me/api/portraits/men/83.jpg",
                        Medium = "https://randomuser.me/api/portraits/med/men/83.jpg",
                        Thumbnail = "https://randomuser.me/api/portraits/thumb/men/83.jpg"
                    },
                    Nat = "SE",   
                };
        }

        public IEnumerable<Contact> GetContacts()
        {
            return new List<Contact> {
                new Contact {
                    Gender = "male",
                    Name = new Name {
                        Title = "Mr.",
                        First = "John",
                        Last = "Smith"
                    },
                    Location = new Location {
                        Street = "StubbleStreet 92",
                        City = "Mårtsbo",
                        State = "Sweden",
                        Postcode = 80286
                    },
                    Email = "john.smith@gmail.com",
                    Login = new Login {
                        Username = "jsmith",
                        Password = "73KgJv60WvE0",
                        Salt = "73KgJv60WvE0",
                        Md5 = "73KgJv60WvE0",
                        Sha1 = "73KgJv60WvE0",
                        Sha256 = "73KgJv60WvE0"
                    },
                    Dob = new System.DateTimeOffset(new System.DateTime(1987, 09, 12)),
                    Registered = new System.DateTimeOffset(new System.DateTime(2015,12,10)),
                    Phone = "",
                    Cell = "+4672143131",
                    Id = new Id {
                        Name = "BSN",
                        Value = "04242023"
                    },
                    Picture = new Picture {
                        Large = "https://randomuser.me/api/portraits/men/83.jpg",
                        Medium = "https://randomuser.me/api/portraits/med/men/83.jpg",
                        Thumbnail = "https://randomuser.me/api/portraits/thumb/men/83.jpg"
                    },
                    Nat = "SE",
                    
                }
            };
        }
    }
}