namespace RTS
{
    public class Payment
    {
        private Table table;
        private Player player;
        public Payment(Table table, Player player)
        {
            this.table = table;
            this.player = player;
        }
        public bool isPayed(int typeId)
        {
            var cost = getCost(typeId);
            if (player.unitCounts < cost)
                return false;
            player.unitCounts -= cost;
            return true;
        }
        private int getCost(int typeId)
        {
            return table.Get(typeId.ToString()).Value("cost");
        }
    }
}
