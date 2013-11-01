using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Mod;
using Dal;
namespace Bll
{
    public class BWork
    {
        DWork dal = new DWork();
        public int InsertWork(Work w)
        {

            return dal.InsertWork(w);

        }
    
     
    }
}