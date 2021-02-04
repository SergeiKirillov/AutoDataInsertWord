using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DBMemoryData
{
    public DateTime dtMemoryDB { get; set; }
    public string strMemoryDB { get; set; }
}

class clDBMemory
{

    public IList<DBMemoryData> Get()
    {
        var resultDB = new List<DBMemoryData>();


        return resultDB;
    }
}

