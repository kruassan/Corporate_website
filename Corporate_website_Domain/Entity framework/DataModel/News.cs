using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corporate_website_Domain.EntityFramework.Models
{
	[Serializable]
	[Table("News", Schema = "public")]
	public class News
	{
		public long? Id { get; set; }

		public char[] Caption { get; set; }

		public string Content { get; set; }

		public long[] News_images_id { get; set; }
	}
}