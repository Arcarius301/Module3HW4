using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW4.Models;

namespace Module3HW4
{
    public class Task2
    {
        private List<Contact> _contacts;
        public Task2()
        {
            _contacts = new List<Contact>
            {
                new Contact() { FirstName = "Paul", LastName = "Dexter", Number = "+380661111111" },
                new Contact() { FirstName = "Geraldine", LastName = "Britt", Number = "+380661121111" },
                new Contact() { FirstName = "Elis", LastName = "Mercado", Number = "+380661113111" },
                new Contact() { FirstName = "Jordi", LastName = "Molina", Number = "+380661114111" },
                new Contact() { FirstName = "Milla", LastName = "Portillo", Number = "+380661151111" },
                new Contact() { FirstName = "Gary", LastName = "Willis", Number = "+380661111611" },
                new Contact() { FirstName = "Hashim", LastName = "Chandler", Number = "+380661171111" },
                new Contact() { FirstName = "Eduard", LastName = "Millington", Number = "+380668111111" },
                new Contact() { FirstName = "Clement", LastName = "Mueller", Number = "+380661191111" },
                new Contact() { FirstName = "Paul", LastName = "Dexter", Number = "+380661111111" }
            };
        }

        public void Run()
        {
            var selectedContacts = _contacts.Where(w => w.LastName.ToUpper().StartsWith("M"))
                                            .OrderBy(o => o.FirstName)
                                            .ThenBy(t => t.FirstName.Length)
                                            .Select(s => s.Number);

            Console.WriteLine("Contacts 1:");
            foreach (var item in selectedContacts)
            {
                Console.WriteLine($"Number: {item}");
            }

            var selectedContacts2 = _contacts.Where(w => w.LastName.ToUpper().StartsWith("M"))
                                             .OrderByDescending(o => o.LastName)
                                             .FirstOrDefault();

            Console.WriteLine("Contacts 2:");
            Console.WriteLine($"First Name: {selectedContacts2.FirstName}, Last Name: {selectedContacts2.LastName}, Number: {selectedContacts2.Number}");
        }
    }
}
