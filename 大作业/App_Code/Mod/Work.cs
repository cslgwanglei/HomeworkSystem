using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
namespace Mod
{
    public class Work
    {
        private int workid;
        private string workname;
        private DateTime starttime;
     
        private bool tip;
        private string comment;
        private float score;
        private bool readOnly;
        private string cname;
      

        public Work(string _workname, DateTime _starttime,  bool _tip, string _comment, float _score, bool _readOnly, string _cname)
        {
            this.workname = _workname;
            this.starttime = _starttime;
            
            this.tip = _tip;
            this.comment = _comment;
            this.score = _score;
            this.readOnly = _readOnly;
            this.cname = _cname;
         
     
        }
        public Work()
        { }

      
        public string Cname
        {
            get { return cname; }
            set{cname=value;}
        }
        public bool ReadOnly
        {
            get { return readOnly; }
            set {readOnly=value;}
        }
        public int Id
        {
            get { return workid; }
            set { workid = value; }
        }
        public DateTime Start
        {
            get { return starttime; }
            set { starttime = value; }
        }

      
        public string Name
        {
            get { return workname; }
            set { workname = value; }
        }
        public bool Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public float  Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}