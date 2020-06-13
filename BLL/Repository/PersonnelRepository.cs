using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Web;

namespace BLL.Repository
{
    //burası iptall..
    public class PersonnelRepository : IPersonnelService
    {
        private readonly AppDbContext context;

        public PersonnelRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Personnel personnel)
        {
            context.Personnels.Add(personnel);
            context.SaveChanges();
            
        }

        public void Delete(int id)
        {

           var personnel= context.Personnels.Where(x=>x.ID==id).FirstOrDefault();
            context.Personnels.Remove(personnel);
            context.SaveChanges();
        }

        public List<Personnel> GetPersonnels()
        {
            return context.Personnels.ToList();
        }

        public void Update(Personnel personnel)
        {
            context.Entry(personnel).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}