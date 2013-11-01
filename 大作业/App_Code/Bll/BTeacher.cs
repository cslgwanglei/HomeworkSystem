using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Mod;
using Dal;
namespace Bll
{

    public class BTeacher
    {
        DTeacher dal = new DTeacher();
        public int InsertTeacher(Teacher t)
        {

            return dal.InsertTeacher(t);

        }
        public IList<Teacher> GetTeacher()
        {
            return dal.GetTeacher();
        }
        public IList<Teacher> SearchTeacher(string tno, string tname)
        {
            return dal.SearchTeacher(tno, tname);
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