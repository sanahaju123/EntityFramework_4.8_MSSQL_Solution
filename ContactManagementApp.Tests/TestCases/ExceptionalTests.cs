


using ContactManagementApp.DAL.Interrfaces;
using ContactManagementApp.DAL.Services;
using ContactManagementApp.DAL.Services.Repository;
using ContactManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ContactManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IContactService _contactService;
        public readonly Mock<IContactRepository> contactservice = new Mock<IContactRepository>();

        private readonly Contact _contact;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _contactService = new ContactService(contactservice.Object);

            _output = output;

            _contact = new Contact
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phone = "123-456-7890"
            };
        }



        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidContactIdIsPassed()
        {
            //Arrange
            bool res = false;
            _contact.Id= 0;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                contactservice.Setup(repo => repo.CreateContact(_contact)).ReturnsAsync(_contact);
                var result = await _contactService.CreateContact(_contact);
                if (result != null || result.Id !=0)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                contactservice.Setup(repo => repo.CreateContact(_contact)).ReturnsAsync(_contact);
                var result = await _contactService.CreateContact(_contact);
                if (result != null || result.FirstName !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidEmailIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                contactservice.Setup(repo => repo.CreateContact(_contact)).ReturnsAsync(_contact);
                var result = await _contactService.CreateContact(_contact);
                if (result != null || result.Email !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidContactNumberIsPassed()
        {
            //Arrange
            bool res = false;
            _contact.Phone = "";
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                contactservice.Setup(repo => repo.CreateContact(_contact)).ReturnsAsync(_contact);
                var result = await _contactService.CreateContact(_contact);
                if (result != null || result.Phone !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}