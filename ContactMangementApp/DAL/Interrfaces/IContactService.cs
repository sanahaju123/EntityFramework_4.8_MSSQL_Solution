using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp.DAL.Interrfaces
{
    public interface IContactService
    {
        List<Contact> GetAllContacts();
        Task<Contact> CreateContact(Contact expense);
        Task<Contact> GetContactById(long id);
        Task<bool> DeleteContactById(long id);
        Task<Contact> UpdateContact(Contact model);
    }
}
