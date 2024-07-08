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
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

		public void TDelete(Testimonial t)
		{
			_testimonialDal.Delete(t);
		}

		public Testimonial TGetById(int id)
		{
			return _testimonialDal.GetById(id);
		}

		public List<Testimonial> TGetList()
		{
			return new List<Testimonial>();
		}

		public void TInsert(Testimonial t)
		{
			_testimonialDal.Insert(t);
		}

		public void TUpdate(Testimonial t)
		{
			_testimonialDal.Update(t);
		}
	}
}
