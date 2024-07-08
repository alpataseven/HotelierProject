using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierEntityLayer.Concrete
{
	public class Service
	{
		[Key]
		public int ServiceId { get; set; }
        public string SerivceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
