using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nu3.Models;
namespace Nu3.Services.Interfaces
{
    public interface IDBCommunication
    {
        bool AddUser(User user);
    }
}
