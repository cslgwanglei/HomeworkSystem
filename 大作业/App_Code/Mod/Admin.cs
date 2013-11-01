using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///Admin 的摘要说明
/// </summary>
namespace Mod{
public class Admin
{
	
       private int id;

       
        private string ano;
       private string aname;
        private string apwd;
       public int Id
       {
           get { return id; }
           set { id = value; }
       }
        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }
       
        public string Aname
        {
            get { return aname; }
            set { aname = value; }
        }
      
        public string Apwd
        {
            get { return apwd; }
            set { apwd = value; }
        }
        public Admin(string _ano,string _aname, string _apwd)
        {
            this.apwd = _apwd;
            this.ano = _ano;
            this.aname = _aname;
        }
        public Admin(string _ano,string _apwd)
        {
            this.apwd = _apwd;
            this.ano = _ano;
        
        }
        public Admin(int _id,string _ano, string _aname, string _apwd)
        {
            this.id = _id;
            this.apwd = _apwd;
            this.ano = _ano;
            this.aname = _aname;
        }
    }
}
