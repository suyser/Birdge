using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birdge
{
  public interface INotificationSender
    {
        void Send(string message);
    }
}

