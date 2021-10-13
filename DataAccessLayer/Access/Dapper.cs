using Dapper;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Access
{
    public class Dapper : IDapper
    {
        private readonly string _connectionString;

        public Dapper(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public List<TimeSheet> GetEntry(string id)
        {
            List<TimeSheet> entries = new();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                entries = connection.Query<TimeSheet>("execute uspGetEntryByID @id", new { @id = id }).ToList();
            }
            return entries;
        }
        public List<TimeSheet> GetEmployeeEntry(DateTime date)
        {
            List<TimeSheet> employeeentry = new();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                employeeentry = connection.Query<TimeSheet>("execute uspGetEmployeesByDate @date", new { @date = date }).ToList();
            }

            return employeeentry;
        }

        public int PresentEmployeesCount()
        {
            int count;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                count = connection.Query<int>("execute uspEmployeePresentToday").FirstOrDefault();
            }

            return count;
        }

        public AspNetUser GetUser(string name)
        {
            AspNetUser user = new();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                AspNetUser? aspNetUser = connection.Query<AspNetUser>("execute uspGetEmployee @mail", new { @mail = name }).FirstOrDefault();
                user = aspNetUser;
            }
            return user;
        }
        public void SetEntry(Entry entry)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Query("execute uspInsertPeviousEntry @date,@id,@intime,@outtime", new { @date = entry.Date, @id = entry.EmployeeId, @intime = entry.InTime, @outtime = entry.OutTime });

                var entryId = connection.Query<Entry>("execute uspGetEntryByID_Date @Id,@Date", new { @Id = entry.EmployeeId, @Date = entry.Date }).FirstOrDefault();

                foreach (var brk in entry.Breaks)
                {
                    connection.Query("execute uspSetFormBreak @EntryId,@BreakIn,@BreakOut", new { @EntryId = entryId.Id, @BreakIn = brk.BreakIn, @BreakOut = brk.BreakOut });
                }
            }
        }
    }
}
