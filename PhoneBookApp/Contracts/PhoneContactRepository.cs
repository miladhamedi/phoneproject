using PhoneBookApp.Data;
using PhoneBookApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Contracts
{
    public class PhoneContactRepository: IPhoneContactRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly IContactRepository contactRepository;

        public PhoneContactRepository(ApplicationDbContext applicationDbContext, IContactRepository contactRepository)
        {
            this.applicationDbContext = applicationDbContext;
            this.contactRepository = contactRepository;
        }
        public void AddPhoneContact(PhoneContact phoneContact)
        {
            PhoneContact Phcontact = new PhoneContact();

            Phcontact.PhoneNumber = phoneContact.PhoneNumber;
            Phcontact.ContactId = phoneContact.ContactId;

            applicationDbContext.PhoneContacts.Add(Phcontact);

            applicationDbContext.SaveChanges();

        }


        public void DeletePhone(PhoneContact phonecontact)
        {
            if (CountPhoneNumber(phonecontact) <= 1)
            {
                applicationDbContext.PhoneContacts.Remove(phonecontact);

                var contact = applicationDbContext.Contacts.Where(c => c.ContactId == phonecontact.ContactId).SingleOrDefault();
                applicationDbContext.Contacts.Remove(contact);


            }
            else
            {
                applicationDbContext.PhoneContacts.Remove(phonecontact);
            }

            applicationDbContext.SaveChanges();
        }

        public int CountPhoneNumber(PhoneContact phonecontact)
        {
            var PhoneCount = applicationDbContext.PhoneContacts.Where(c => c.ContactId == phonecontact.ContactId).ToList().Count();
            return PhoneCount;
        }

        public List<PhoneContact> GetAll(Guid contactid)
        {
            var PhoneContact = applicationDbContext.PhoneContacts.Where(c => c.ContactId == contactid).ToList();
            return PhoneContact;
        }

        public PhoneContact GetById(Guid phonecontactid)
        {
            var item = applicationDbContext.PhoneContacts.Where(c => c.PhoneContactId == phonecontactid).FirstOrDefault();
            return item;
        }

        public void Save()
        {
            applicationDbContext.SaveChanges();
        }
    }
}
