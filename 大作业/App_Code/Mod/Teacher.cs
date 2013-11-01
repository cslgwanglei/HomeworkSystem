using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mod {
public class Teacher
{
    private string tno;
    private string tname;
    private string tpwd;
    public string Tno
    {
        get { return tno; }
        set { tno = value; }
    }
    public string Tname
    {
        get { return tname; }
        set { tname = value; }
    }

    public string Tpwd
    {
        get { return tpwd; }
        set { tpwd = value; }
    }
    public Teacher()
    { }
    public Teacher(string _tno, string _tname, string _tpwd)
    {
        this.tno = _tno;
        this.tpwd = _tpwd;
        this.tname = _tname;

    }
}
}