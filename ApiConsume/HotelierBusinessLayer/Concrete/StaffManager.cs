using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierBusinessLayer.Abstract;
using HotelierDataAccessLayer.Abstract;
using HotelierEntityLayer.Concrete;

namespace HotelierBusinessLayer.Concrete
{
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public void TDelete(Staff t)
		{
			_staffDal.Delete(t);
		}

		public Staff TGetById(int id)
		{
			return _staffDal.GetById(id);
		}

		public List<Staff> TGetList()
		{
			return new List<Staff>();
		}

		public void TInsert(Staff t)
		{
			_staffDal.Insert(t);
		}

		public void TUpdate(Staff t)
		{
			_staffDal.Update(t);
		}
	}
}
