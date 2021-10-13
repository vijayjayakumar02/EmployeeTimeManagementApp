using DataAccessLayer.Access;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class EntryBL
    {
        
        private readonly IDapper dapper;
        private readonly EntryDAL _entryDAL;

        public EntryBL(IDapper dapper,EntryDAL entryDAL)
        {
            this.dapper = dapper;
            this._entryDAL = entryDAL;
        }
        public List<TimeSheet> GetEntry(string id)
        {
            var entries = dapper.GetEntry(id);

            return entries;
        }
        public AspNetUser GetUsers(string name)
        {
            AspNetUser user = dapper.GetUser(name);

            return user;
        }
        public void CreateEntry(TimeSheet model)
        {
            if(model.TimeIn != null)
            {
                Entry entry = new Entry
                {
                    EmployeeId = model.EmployeeId,
                    Date = model.Date,
                    InTime = model.TimeIn,
                    OutTime = model.TimeOut,
                    Breaks = model.BreakList
                };
                dapper.SetEntry(entry);
            }
        } 

        public List<TimeSheet> GetEmployeeEntry(DateTime date)
        {
            var employee = dapper.GetEmployeeEntry(date);
            return employee;
        }

        public int EmployeesCount()
        {
            var count = dapper.PresentEmployeesCount();
            return count;
        }
    }
}
