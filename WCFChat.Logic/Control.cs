using WCFChat.Logic.Server;

namespace WCFChat.Logic
{
    public class Control
    {
        public string Test(int value)
        {
            Service1Client client = new Service1Client();

            return client.GetData(value);
        }
    }
}
