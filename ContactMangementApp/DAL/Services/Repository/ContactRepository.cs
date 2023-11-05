using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactManagementApp.DAL.Services.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DatabaseContext _dbContext;
        public ContactRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Contact> CreateContact(Contact expense)
        {
            try
            {
                var result =  _dbContext.Contacts.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteContactById(long id)
        {
            try
            {
                _dbContext.Contacts.Remove(_dbContext.Contacts.Single(a => a.Id == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Contact> GetAllContacts()
        {
            try
            {
                var result = _dbContext.Contacts.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Contact> GetContactById(long id)
        {
            try
            {
                return await _dbContext.Contacts.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Contact> UpdateContact(Contact model)
        {
            var ex = await _dbContext.Contacts.FindAsync(model.Id);
            try
            {
                ex.Email = model.Email;
                ex.LastName = model.LastName;
                ex.FirstName = model.FirstName;
                ex.Phone = model.Phone;
                ex.Id = model.Id;

                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}