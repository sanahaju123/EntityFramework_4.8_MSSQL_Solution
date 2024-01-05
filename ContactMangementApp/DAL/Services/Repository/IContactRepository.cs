using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp.DAL.Services.Repository
{
    public interface IContactRepository
    {
        List<Contact> GetAllContacts();
        Task<Contact> CreateContact(Contact contact);
        Task<Contact> GetContactById(long id);
        Task<bool> DeleteContactById(long id);
        Task<Contact> UpdateContact(Contact model);
    }
}

