using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mod
{
    public class Student
    {
        private string sno;
        private string sname;
        private string classid;
        private string spwd;
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }
        public string Sclass
        {
            get { return classid; }
            set { classid = value; }
        }
        public string Spwd
        {
            get { return spwd; }
            set { spwd = value; }
        }
        public Student()
        { }
        public Student(string _sno, string _sname, string _classid, string _spwd)
        {
            this.sno = _sno;
            this.spwd = _spwd;
            this.sname = _sname;
            this.classid = _classid;
        }
        public Student(string _sno, string _sname, string _classid)
        {
            this.sno = _sno;
           
            this.sname = _sname;
            this.classid = _classid;
        }


    }
}