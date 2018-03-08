using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Xunit;
using Nu3.Services.Interfaces;
using Nu3.Models;
using FakeItEasy;
namespace Tests.Services.UserService
{
    public class When_adding_new_user
    {/*
        readonly Nu3.Services.UserService _userService;
        readonly IDBCommunication _dbCommunication;


        public When_adding_new_user()
        {
            _dbCommunication = A.Fake<IDBCommunication>();
            _userService = new Nu3.Services.UserService(_dbCommunication);
        }

        [Fact]
        public void Should_throw_exception_if_null_parameter_is_given()
        {
            Assert.Throws<ArgumentNullException>(() => _userService.AddUser(null));
        }

        [Fact]
        public void Should_throw_exception_if_missing_firstname()
        {
            Assert.Throws<ArgumentException>(() => _userService.AddUser(new User
            {
                Lastname = "Stoltenberg",
                SocialSecurityNumber = "01010144221"
            }));

        }

        [Fact]
        public void Should_throw_exception_if_missing_lastname()
        {
            Assert.Throws<ArgumentException>(() => _userService.AddUser(new User
            {
                Firstname = "Jens",
                SocialSecurityNumber = "01010144221"

            }));

        }

        [Fact]
        public void Should_throw_exception_if_missing_socialsecuritynumber()
        {
            Assert.Throws<ArgumentException>(() => _userService.AddUser(new User
            {
                Firstname = "Jens",
                Lastname = "Stoltenberg"

            }));

        }

        [Fact]
        public void Should_call_add_dbcommunication()
        {
            User user = new User
            {
                Firstname = "Jens",
                Lastname = "Stoltenberg",
                SocialSecurityNumber = "01010112331"

            };

            _userService.AddUser(user);

            A.CallTo(() => _dbCommunication.AddUser(null)).WithAnyArguments().MustHaveHappened();

        }

        [Fact]
        public void Should_throw_exception_when_dbcommunication_add_fails()
        {
            A.CallTo(() => _dbCommunication.AddUser(null)).WithAnyArguments().Returns(false);
            User user = new User
            {
                Firstname = "Jens",
                Lastname = "Stoltenberg",
                SocialSecurityNumber = "01010112331"

            };

            Assert.Throws<ExternalException>(() => _userService.AddUser(user));

        }
*/
    }
}
