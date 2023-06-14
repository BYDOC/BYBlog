using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Interfaces
{
    public interface ISubscriberService
    {
        void AddSubscriber(Subscriber sub);
        void DeleteSubscriber(Subscriber sub);
        void UpdateSubscriber(Subscriber sub);
    }
}
