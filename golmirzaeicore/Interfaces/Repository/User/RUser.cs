using System.Net.Mime;
using golmirzaeicore.Interfaces.User;
using golmirzaeidatalayer.Entities.User;
using golmirzaeidatalayer.Context;
using golmirzaeiCore.DTOs.User;
using System.Collections.Generic;
using System.Linq;

namespace golmirzaeicore.Interfaces.Repository.User
{
    public class RUser : IUser
    {
        private readonly Application db;
        public RUser(Application _db)
        {
            db = _db;
        }

        public bool Add(Vm_User k)
        {
            if (k != null)
            {
                try
                {
                    Tbl_User tbl_User = new Tbl_User()
                    {
                        Name = k.Vm_Name,
                        Family = k.Vm_Family,
                        Status = true,
                    };
                    db.tbl_Users.Add(tbl_User);
                    db.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
            }else
            {
                return false;
            }
        }
        public List<Tbl_User> FindAllUser()
        {
            var all = db.tbl_Users.ToList();
            return all;
        }
        public Vm_User FindUser(int id)
        {
            var find = db.tbl_Users.SingleOrDefault(p=>p.Id == id);
            Vm_User vm_User = new Vm_User()
            {
                Vm_Id = find.Id,
                Vm_Family = find.Family,
                Vm_Name = find.Name,
                Vm_Status = find.Status,
            };
            return vm_User;
        }
        public bool Status(int id)
        {
           try
           { 
                var find = db.tbl_Users.SingleOrDefault(p=>p.Id == id);
                if (find.Status == true)
                {
                     find.Status = false;
                }else
                {
                     find.Status = true;
                }
                db.tbl_Users.Update(find);
                db.SaveChanges();
                return true;
           }
           catch (System.Exception)
           {
                return false;
           }
        }
        public bool Update(Vm_User k)
        {
            if (k != null)
            {
                try
                {
                    var find = db.tbl_Users.SingleOrDefault(p=>p.Id == k.Vm_Id);
                    if (find != null)
                    {
                        find.Name = k.Vm_Name;
                        find.Family = k.Vm_Family;
                        db.tbl_Users.Update(find);
                        db.SaveChanges();
                        return true;
                    }else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {  
                    return false;
                }   
            }else
            {
                return false;
            }
        }
    }
}