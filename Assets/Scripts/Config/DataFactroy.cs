namespace RTS
{
    public class DataFactroy
    {
        public virtual Database Factroy()
        {
            return new Database();
        }
    }
}
