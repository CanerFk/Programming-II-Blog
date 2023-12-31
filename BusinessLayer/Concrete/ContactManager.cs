using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactDal _ContactDal;
        public ContactManager(IContactDal contactDal)
        {
            _ContactDal = contactDal;
        }
        public void ContactAdd(Contact contact)
		{
			_ContactDal.Insert(contact);
		}
	}
}
