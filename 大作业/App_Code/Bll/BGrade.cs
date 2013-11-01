using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Mod;
using Dal;
namespace Bll
{
    public class BGrade
    {
        DGrade dal = new DGrade ();
        public int InsertGrade(Grade  t)
        {

            return dal.InsertGrade(t);

        }
        public bool DeleteGrade(string workname)
        {

            return dal.DeleteGrade (workname);

        }
        public int UpdateGrade(Grade g)
        {
            return dal.UpdateGrade(g);
        }
        public int UpdateGrade2(Grade g)
        {
            return dal.UpdateGrade2(g);
        }
    }
}