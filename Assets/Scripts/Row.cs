using System;
using System.Collections.Generic;

namespace RTS
{
    public class Row
    {
        Dictionary<string, int> tables = new Dictionary<string, int>();
        public void Add(string v, int table)
        {
            tables.Add(v, table);
        }

        public int Get(string v)
        {
            return tables[v];
        }
    }
}
