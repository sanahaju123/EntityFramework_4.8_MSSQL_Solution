using ContactManagementApp.DAL.Interrfaces;
using ContactManagementApp.DAL.Services.Repository;
using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactManagementApp.DAL.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public Task<Contact> CreateContact(Contact contact)
        {
            return _repository.CreateContact(contact);
        }

        public Task<bool> DeleteContactById(long id)
        {
            return _repository.DeleteContactById(id);
        }

        public List<Contact> GetAllContacts()
        {
            return _repository.GetAllContacts();
        }

        public Task<Contact> GetContactById(long id)
        {
            return _repository.GetContactById(id); ;
        }

        public Task<Contact> UpdateContact(Contact model)
        {
            return _repository.UpdateContact(model);
        }
    }
}