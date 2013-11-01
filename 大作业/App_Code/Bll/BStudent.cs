using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Mod;
using Dal;
namespace Bll
{
    public class BStudent
    {
        DStudent dal = new DStudent();
        public int InsertStudent(Student st)
        {

            return dal.InsertStudent(st);

        }
       
        public bool CheckUser(string nName, string nPass)
        {

            if (string.IsNullOrEmpty(nName) || string.IsNullOrEmpty(nPass))
            {
                return false;
            }
            else
            {
                return dal.CheckUser(nName, nPass);

            }

        }


     
    }
}