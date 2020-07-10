using PhoneBookApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookApp.Contracts
{
    public interface IPhoneContactRepository
    {
        void AddPhoneContact(PhoneContact phoneContact);
        List<PhoneContact> GetAll(Guid contactid);
        void DeletePhone(PhoneContact phonecontact);
        PhoneContact GetById(Guid phonecontactid);
        void Save();
        int CountPhoneNumber(PhoneContact phonecontact);
    }
}
