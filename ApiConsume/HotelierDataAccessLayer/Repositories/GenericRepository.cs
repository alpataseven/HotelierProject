using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierDataAccessLayer.Abstract;
using HotelierDataAccessLayer.Concrete;

namespace HotelierDataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		private readonly Context _context; //Context sınıfından _context örneği aldık.
		public GenericRepository(Context context)
		{
			_context = context;
		}
		public void Delete(T t)
		{
			_context.Remove(t); //t den gelen degeri sil.
			_context.SaveChanges(); //degisiklikleri kaydet.
		}

		public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			return _context.Set<T>().ToList();
		}

		public void Insert(T t)
		{
			_context.Add(t);
			_context.SaveChanges();
		}

		public void Update(T t)
		{
			_context.Update(t);
			_context.SaveChanges();
		}
	}
}
