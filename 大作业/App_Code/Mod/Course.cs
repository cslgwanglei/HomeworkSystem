using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace Mod
{
    public class Course
    {
        private int cno;
        private string cname;
        private string cinfo;
        public int Cno
        {
            get { return cno; }
            set { cno = value; }
        }
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        public string Cinfo
        {
            get { return cinfo; }
            set { cinfo = value; }
        }
        public Course() { }
        public Course(string _cname, string _cinfo)
        {
            this.cname = _cname;
            this.cinfo = _cinfo;

        }
        public Course(int _cno, string _cname, string _cinfo)
        {
            this.cname = _cname;
            this.cinfo = _cinfo;
            this.cno = _cno;
        }
    }
}