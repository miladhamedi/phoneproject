using PhoneBookApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Contracts
{
    public interface IContactRepository
    {
        List<Contact> GetAllContact();
        Guid AddContact(Contact contact);
        void Delete(Contact contactid);
        Contact GetById(Guid contactid);
        void Save();
        List<Contact> Search(string input);
    }
}
