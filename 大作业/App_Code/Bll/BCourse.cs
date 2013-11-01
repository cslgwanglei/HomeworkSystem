using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Mod;
using Dal;
namespace Bll
{
    public class BCourse
    {

        DCourse dal = new DCourse();
        public int InsertCourse(Course t)
        {

            return dal.InsertCourse(t);

        }
        public IList<Course> GetCourse()
        {
            return dal.GetCourse();
        }
        public IList<Course> SearchCourse(string cname)
        {
            return dal.SearchCourse(cname);
        }

    }
}