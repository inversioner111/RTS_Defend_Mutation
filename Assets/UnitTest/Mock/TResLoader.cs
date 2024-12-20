using RTS;

namespace UnitTest
{
    internal class TResLoader : ResLoader
    {
        internal string log;
        public override T Load<T>(string path)
        {
            log += $"load:{path}";
            return base.Load<T>(path);
        }
        public override T Instantiate<T>(string path)
        {
            log += $"instanse";
            return base.Instantiate<T>(path);
        }
    }
}