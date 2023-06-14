using BYBlog.BL.Interfaces;
using BYBlog.DAL.Interfaces;
using BYBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.BL.Concrete
{
    public class SubscriberManager : ISubscriberService
    {
        ISubscriber _subscriber;
        public SubscriberManager(ISubscriber subscriber)
        {
            _subscriber = subscriber;
        }
        public void AddSubscriber(Subscriber sub)
        {
            _subscriber.Insert(sub);
        }

        public void DeleteSubscriber(Subscriber sub)
        {
            _subscriber.Delete(sub);
        }

        public void UpdateSubscriber(Subscriber sub)
        {
            _subscriber.Update(sub);
        }
    }
}
