namespace RTS
{
    public class Payment
    {
        private Database database;
        private Player player;
        public Payment(Database database, Player player)
        {
            this.database = database;
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
            return database.Get("units").Get(typeId.ToString()).Get("cost");
        }
    }
}
