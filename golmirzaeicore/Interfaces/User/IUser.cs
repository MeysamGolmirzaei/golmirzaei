using golmirzaeidatalayer.Entities.User;
using golmirzaeidatalayer.Context;
using golmirzaeicore.Interfaces.Repository.User;
using System.Collections;
using System.Collections.Generic;
using golmirzaeiCore.DTOs.User;

namespace golmirzaeicore.Interfaces.User
{
    public interface IUser
    {
         List<Tbl_User> FindAllUser();
         bool Add(Vm_User k);
         Vm_User FindUser(int id);
         bool Update(Vm_User k);
         bool Status(int id);
    }
}