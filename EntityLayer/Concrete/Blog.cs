using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Blog
	{
		[Key]
		public int BlogID { get; set; }
		public string BlogTitle { get; set; }
		public string BlockImage { get; set; }
		public string BlockThubnailImage { get; set; }
		public string BlogContent { get; set; }
		public DateTime BlogCreateDate { get; set; }
		public bool BlogStatus { get; set; }
		public int CategoryID { get; set; }
		public Category Category { get; set; } = new Category();
		public int WriterID { get; set; }
		public Writer Writer { get; set; } = new Writer();
		public List<Comment> Comments { get; set; }
	}
}
