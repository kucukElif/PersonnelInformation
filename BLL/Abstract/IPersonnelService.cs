using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    //burası iptal...
  public  interface IPersonnelService
    {
        List<Personnel> GetPersonnels();
        void Add(Personnel personnel);
        void Update(Personnel personnel);
        void Delete(int id);
    }
}
