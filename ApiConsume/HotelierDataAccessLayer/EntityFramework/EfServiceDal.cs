using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierDataAccessLayer.Abstract;
using HotelierDataAccessLayer.Concrete;
using HotelierDataAccessLayer.Repositories;
using HotelierEntityLayer.Concrete;

namespace HotelierDataAccessLayer.EntityFramework
{
	public class EfServiceDal : GenericRepository<Service>, IServiceDal
	{
		public EfServiceDal(Context context) : base(context)
		{
		}
	}
}
