using ContactManagement.Models;
using ContactManagementApp.DAL.Interrfaces;
using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactManagementApp.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService _service;
        public ContactController(IContactService service)
        {
            _service = service;
        }
        public ContactController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Contact/CreateContact")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateContact([FromBody] Contact model)
        {
            var leaveExists = await _service.GetContactById(model.Id);
            var result = await _service.CreateContact(model);
            return Ok(new Response { Status = "Success", Message = "Contact created successfully!" });
        }


        [HttpPut]
        [Route("api/Contact/UpdateContact")]
        public async Task<IHttpActionResult> UpdateContact([FromBody] Contact model)
        {
            var result = await _service.UpdateContact(model);
            return Ok(new Response { Status = "Success", Message = "Contact updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Contact/DeleteContact")]
        public async Task<IHttpActionResult> DeleteContact(long id)
        {
            var result = await _service.DeleteContactById(id);
            return Ok(new Response { Status = "Success", Message = "Contact deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Contact/GetContactById")]
        public async Task<IHttpActionResult> GetContactById(long id)
        {
            var contact = await _service.GetContactById(id);
            return Ok(contact);
        }


        [HttpGet]
        [Route("api/Contact/GetAllContacts")]
        public async Task<IEnumerable<Contact>> GetAllContacts()
        {
            return _service.GetAllContacts();
        }
    }
}
