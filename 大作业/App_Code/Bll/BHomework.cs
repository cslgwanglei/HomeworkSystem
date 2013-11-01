using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Mod;
using Dal;
namespace Bll
{
    public class BHomework
    {
        DHomework dal = new DHomework();
        public int InsertHomework(Homework  t)
        {

            return dal.InsertHomework(t);

        }
        public int UpdateHomework(Homework  t)
        {

            return dal.UpdateHomework(t);

        }
        public int UpdateHomework2(Homework t)
        {

            return dal.UpdateHomework2 (t);

        }
    }
}