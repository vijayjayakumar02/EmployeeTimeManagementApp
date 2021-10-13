using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IDapper
    {
        void SetEntry(Entry entry);
        List<TimeSheet> GetEntry(string id);
        AspNetUser GetUser(string name);
        List<TimeSheet> GetEmployeeEntry(DateTime date);
        int PresentEmployeesCount();

    }
}
