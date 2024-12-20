using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS
{
    public class Table
    {
        Dictionary<string, Row> tables = new Dictionary<string, Row>();
        public void Add(string v, Row table)
        {
            tables.Add(v, table);
        }

        internal Row Get(string v)
        {
            return tables[v];
        }
    }
}
