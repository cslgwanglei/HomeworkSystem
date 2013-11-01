using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Dal;
using Mod;
namespace Bll
{
    public class BAdmin
    {

        DAdmin dal = new DAdmin();
        public int InsertAdmin(Admin a)
        {

            return dal.InsertAdmin(a);

        }
    
        public bool CheckUser(string nNo, string nPass)
        {

            if (string.IsNullOrEmpty(nNo) || string.IsNullOrEmpty(nPass))
            {
                return false;
            }
            else
            {
                return dal.CheckUser(nNo, nPass);

            }

        }

    }
}
