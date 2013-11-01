using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
namespace Mod
{
    public class Grade
    {
        private string workname;
        private string sno;
        private string tname;
        private string cname;
        private string  score;
        private bool done;
        private string comment;
        private string workdata;
        private string appraise;
        private float grade;
        private bool readOnly;
        private bool upload;
        private bool remark;
        private string classid;
        public string  Classid
        {
            get { return classid; }
            set { classid = value;}
        }
        public string Workname
        {
            get { return workname; }
            set { workname  = value; }
        }
        public string Sno
        {
            get { return sno; }
            set { sno  = value; }
        }
        public string Tname
        {
            get { return tname ; }
            set { tname  = value; }
        }
        public string Cname
        {
            get { return cname ; }
            set { cname  = value; }
        }
        public string  Score
        {
            get { return score ; }
            set { score  = value; }
        }
        public bool Done
        {
            get { return done ; }
            set { done  = value; }
        }
        public string Comment
        {
            get { return comment ; }
            set { comment  = value; }
        }
        public string Workdata
        {
            get { return workdata ; }
            set { workdata  = value; }
        }
        public string Appraise
        {
            get { return appraise  ; }
            set { appraise  = value; }
        }
        public float GRade1
        {
            get { return grade; }
            set { grade = value; }
        }
        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly  = value; }
        }
        public bool Upload
        {
            get { return upload; }
            set { upload  = value; }
        }
       public  bool Remark
        {
            get { return remark ; }
            set { remark  = value; }
        } 
        public Grade()
        { }
        public Grade(string _workname,string _sno,string _cname,string  _score,string _comment,string _workdata,bool _done,bool _readOnly,bool _upload,bool _remark,string _classid)

        {
            this.workname  = _workname ;
            this.sno = _sno;
            this.cname = _cname;
            this.score = _score;
            this.comment = _comment;
            this.workdata = _workdata;
            this.done = _done;
            this.readOnly = _readOnly;
            this.upload = _upload;
            this.remark = _remark;
            this.classid = _classid;
        }
        public Grade(string _sno,string _classid)
        {
            this.sno = _sno;
            this.classid = _classid;
        }
        public Grade(string _workname,string _sno,string _cname,float _grade,string _appraise,bool _remark,string _tname)
        {
            this.workname = _workname;
            this.sno = _sno;
            this.cname = _cname;
            this.grade = _grade;
            this.appraise = _appraise;
            this.remark = _remark;
            this.tname = _tname;
        }
        public Grade(string _workname,string _sno, string _cname,bool _done )
        {
            this.workname = _workname;
            this.sno = _sno;
            this.cname = _cname;
            this.done = _done;
        }
    }
}