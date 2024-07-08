using HotelierBusinessLayer.Abstract;
using HotelierEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		[HttpGet]
		public IActionResult TestimonialList()
		{
			var values = _testimonialService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult Addtestimonial(Testimonial testimonial)
		{
			_testimonialService.TInsert(testimonial);
			return Ok();
		}
		[HttpDelete]
		public IActionResult Deletetestimonial(int id)
		{
			var values = _testimonialService.TGetById(id);
			_testimonialService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult Updatetestimonial(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult Gettestimonial(int id)
		{
			var values = _testimonialService.TGetById(id);
			return Ok(values);
		}
	}
}
