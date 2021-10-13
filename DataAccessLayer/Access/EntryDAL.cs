using DataAccessLayer.DataContext;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Access
{
    public class EntryDAL
    {
        private readonly AppDbContext _appdbContext;
        private readonly EmployeeManagementDBContext _db;
        private readonly UserManager<IdentityUser> userManager;

        public EntryDAL(AppDbContext appdbContext,EmployeeManagementDBContext db, UserManager<IdentityUser> userManager)
        {
            _appdbContext = appdbContext;
            this._db = db;
            this.userManager = userManager;
        }
        public async Task<IdentityUser> GetUser(string name)
        {
            IdentityUser user = await userManager.FindByEmailAsync(name);

            return user;
        }
        public async Task<Entry> GetEntry(string id)
        {
            var entry = await _appdbContext.Entries.FindAsync(id);
            return entry;
        }
        
        public void setEntry(Entry entry)
        {
            _appdbContext.Entries.Add(entry);
            _appdbContext.SaveChanges();
        }
        public void setBreak(Break breakentry)
        {
            _appdbContext.Breaks.Add(breakentry);
            _appdbContext.SaveChanges();
        }
    }
}
