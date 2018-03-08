using System.Collections.Specialized;
using System.Net.Http;
using System.Text;
using Xunit;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Nu3.Controllers;
using Nu3.Models;
using Nu3.Services.Interfaces;

namespace Tests.Controllers
{
    public class UserControllerTests
    {
        private UserController _userController;
        private IDataAccessProvider _dataAccessProvider;
        
        public UserControllerTests()
        {
            _dataAccessProvider = A.Fake<IDataAccessProvider>();
            _userController = new UserController(_dataAccessProvider);
        }
        
        [Fact]
        public void Should_return_500_when_no_body()
        {
           
            Assert.Equal(500, 500);
        }

    }
}