using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
namespace Mod
{
    public class Homework
    {
        private string classid;
        private string sno;
        private string comment;
        private float score;
        private string workname;
        private string cname;
        private DateTime starttime;
        private DateTime endtime;
        private bool hand;
        public bool Hand { 
        get  {return  hand;}
        set{ hand=value ;}
        }
        public string Classid
        {
            get { return classid; }
            set { classid = value; }
        }
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public float Score
        {
            get { return score; }
            set { score = value; }
        }
        public string Workname
        {
            get { return workname; }
            set { workname = value; }
        }
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        public DateTime Starttime
        {
            get { return starttime; }
            set { starttime = value; }
        }
        public DateTime Endtime
        {
            get { return endtime; }
            set { endtime = value; }
        }
        public Homework(string _sno, bool _hand) { this.hand = _hand; this.sno = _sno; }
        public Homework(string _classid, string _sno) { this.classid = _classid; this.sno = _sno; }
        public Homework(string _classid, string _comment, float _score, string _workname, string _cname, DateTime _starttime, DateTime _endtime,bool  _hand)
        {
            this.classid = _classid;
            this.comment = _comment;
            this.score = _score;
            this.workname = _workname;
            this.cname = _cname;
            this.starttime = _starttime;
            this.endtime = _endtime;
            this.hand=_hand;
        }
        public Homework(bool _hand)
        { this.hand = _hand; }
    }
}