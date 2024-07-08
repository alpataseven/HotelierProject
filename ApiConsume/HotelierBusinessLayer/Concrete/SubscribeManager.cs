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
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}

		public void TDelete(Subscribe t)
		{
			_subscribeDal.Delete(t);
		}

		public Subscribe TGetById(int id)
		{
			return _subscribeDal.GetById(id);
		}

		public List<Subscribe> TGetList()
		{
			return new List<Subscribe>();
		}

		public void TInsert(Subscribe t)
		{
			_subscribeDal.Insert(t);
		}

		public void TUpdate(Subscribe t)
		{
			_subscribeDal?.Update(t);
		}
	}
}
