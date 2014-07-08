using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace MyWcfPipeTypes
{
    public class MyPipeServer : IDisposable
    {
        public Boolean IsDisposed
        {
            get;
            set;
        }

        ServiceHost host;
        public MyPipeServer()
        {
            Init();
        }

        public void Init()
        {
            if (host != null) 
                Dispose();
            IsDisposed = false;
            MyService service = new MyService();
            host = new ServiceHost(service, new Uri[] { new Uri(Constants.myPipeService) });
            host.AddServiceEndpoint(typeof(IMyService), new NetNamedPipeBinding(), Constants.myPipeServiceName);
        }
        public void Open()
        {
            host.BeginOpen(OnOpen, host);
        }
        public void Close()
        {
            host.BeginClose(OnClose, host);
        }
        public void Dispose()
        {
            ((IDisposable)host).Dispose();
            IsDisposed = true;
            host = null;
        }

        void OnOpen(IAsyncResult ar)
        {
            ServiceHost service = (ServiceHost)ar.AsyncState;
            service.EndOpen(ar);
        }
        void OnClose(IAsyncResult ar)
        {
            ServiceHost service = (ServiceHost)ar.AsyncState;
            service.EndClose(ar);
            Dispose();
        }
    }
}
