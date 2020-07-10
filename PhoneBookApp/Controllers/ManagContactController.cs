using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Contracts;
using PhoneBookApp.Domains;

namespace PhoneBookApp.Controllers
{
    public class ManagContactController : Controller
    {
        private readonly IContactRepository contactRepository;
        private readonly IPhoneContactRepository phoneContactRepository;

        public ManagContactController(IContactRepository contactRepository, IPhoneContactRepository phoneContactRepository)
        {
            this.contactRepository = contactRepository;
            this.phoneContactRepository = phoneContactRepository;
        }
        public IActionResult Index()
        {
            var ContactList = contactRepository.GetAllContact();
            return View(ContactList);
        }

        public IActionResult CreateContact()
        {

            return View();

        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            var ContactId = contactRepository.AddContact(contact);

            return RedirectToAction("CreatePhoneContact", new { contactid = ContactId });

        }


        public IActionResult Delete(Guid contactid)
        {
            var item = contactRepository.GetById(contactid);

            contactRepository.Delete(item);

            return RedirectToAction("Index");


        }

        public IActionResult CreatePhoneContact(Guid contactid)
        {
            ViewBag.ContactId = contactid;
            return View();

        }

        [HttpPost]
        public IActionResult CreatePhoneContact(PhoneContact phoneContact, Guid contactid)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            phoneContact.ContactId = contactid;

            phoneContactRepository.AddPhoneContact(phoneContact);

            return RedirectToAction("Index");

        }


        public IActionResult Update(Guid contactid)
        {
            var item = contactRepository.GetById(contactid);

            var contact = new Contact();

            contact.Firstname = item.Firstname;
            contact.LastName = item.LastName;
            contact.NationalCode = item.NationalCode;


            return View(contact);

        }


        [HttpPost]

        public IActionResult Update(Contact contact)
        {
            var item = contactRepository.GetById(contact.ContactId);

            item.Firstname = contact.Firstname;
            item.LastName = contact.LastName;
            item.NationalCode = contact.NationalCode;

            contactRepository.Save();

            return RedirectToAction("Index");

        }

        public IActionResult ListPhoneContact(Guid Contactid)
        {

            var Contactlist = phoneContactRepository.GetAll(Contactid);
            return View(Contactlist);

        }

        public IActionResult DeletePhone(Guid phonecontactid)
        {

            var item = phoneContactRepository.GetById(phonecontactid);
            phoneContactRepository.DeletePhone(item);

            return RedirectToAction("Index");

        }

        public IActionResult UpdatePhone(Guid phonecontactid)
        {
            var item = phoneContactRepository.GetById(phonecontactid);

            var contactphone = new PhoneContact();

            contactphone.PhoneNumber = item.PhoneNumber;

            return View(contactphone);

        }


        [HttpPost]
        public IActionResult UpdatePhone(PhoneContact phoneContact)
        {
            var item = phoneContactRepository.GetById(phoneContact.PhoneContactId);

            item.PhoneNumber = phoneContact.PhoneNumber;

            phoneContactRepository.Save();

            return RedirectToAction("Index");

        }



        public IActionResult CreatePhoneNumber(Guid contactid)
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePhoneNumber(PhoneContact phoneContact)
        {
            phoneContactRepository.AddPhoneContact(phoneContact);

            return RedirectToAction("Index");
        }




        public IActionResult SearchContent(string contact)
        {
            contactRepository.Search(contact);

            return RedirectToAction("Index");
        }
    }
}
