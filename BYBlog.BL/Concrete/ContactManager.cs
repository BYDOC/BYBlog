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
    public class ContactManager : IContactService      
    {
        IContact _contact;
        public ContactManager(IContact contact)
        {
            _contact = contact;
        }
        public void AddContact(Contact contact)
        {
            _contact.Insert(contact);
        }

        public void DeleteContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact GetContactById(int id)
        {
            return _contact.GetById(id);
        }

        public void UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
