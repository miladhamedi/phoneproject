using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Data;
using PhoneBookApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Contracts
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ContactRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Guid AddContact(Contact contact)
        {
            var Contacts = new Contact();

            Contacts.Firstname = contact.Firstname;
            Contacts.LastName = contact.LastName;
            Contacts.NationalCode = contact.NationalCode;

            applicationDbContext.Contacts.Add(contact);
            applicationDbContext.SaveChanges();
            return contact.ContactId;

        }

        public void Delete(Contact contactid)
        {
            applicationDbContext.Contacts.Remove(contactid);

            applicationDbContext.SaveChanges();
        }

        public List<Contact> GetAllContact()
        {
            var ContactList = applicationDbContext.Contacts.Include(c => c.PhoneContacts).AsNoTracking().ToList();
            return ContactList;
        }

        public Contact GetById(Guid contactid)
        {
            var Contact = applicationDbContext.Contacts.Where(c => c.ContactId == contactid).SingleOrDefault();
            return Contact;
        }

        public void Save()
        {
            applicationDbContext.SaveChanges();
        }

        public  List<Contact> Search(string input)
        {
            var ContctList = new List<Contact>();
            if (!string.IsNullOrEmpty(input))
            {
                ContctList =  applicationDbContext.Contacts.Include(c => c.PhoneContacts).Where(c => c.LastName.Contains(input) ||
                  c.Firstname.Contains(input) ||
                  c.NationalCode.Contains(input) ||
                  c.PhoneContacts.First().PhoneNumber.Contains(input)).ToList();
            }
            return ContctList;
        }

        
    }

}
