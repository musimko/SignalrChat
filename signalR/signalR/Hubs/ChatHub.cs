using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
//서버
namespace signalR.Hubs
{
    [HubName("chatt")]
    //클라이언트에서 사용할때는 chat_samii이라는 이름으로 보겟다.
    public class ChatHub : Hub
    {
        public void Hello(string msg)
        {
            Clients.All.hello(msg);
        }
    }
}