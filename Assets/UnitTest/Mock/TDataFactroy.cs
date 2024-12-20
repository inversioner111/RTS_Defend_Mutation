using RTS;

namespace UnitTest
{
    internal class TDataFactroy : DataFactroy
    {
        public Database data;
        public TDataFactroy()
        {
            data = new Database();
            var table = new Table();
            var row = new Row();
            row.Add("cost", 10);
            table.Add("1000", row);
            data.Add("units", table);
            table = new Table();
            row = new Row();
            row.Add("value", 10);
            table.Add("unitcounts", row);
            data.Add("values", table);
        }
        public override Database Factroy()
        {
            return data;
        }
    }
}