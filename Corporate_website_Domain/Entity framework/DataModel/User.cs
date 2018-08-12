using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Threading.Tasks;

namespace Corporate_website_Domain.EntityFramework.Models
{
	[Serializable]
	[Table("User", Schema = "public")]
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string Login { get; set; }

		public string Pass_hash { get; set; }

		public DateTime? Registration_time { get; set; }

		public bool? Banned { get; set; }

		public long? Ban_data_id { get; set; }

		public long? Id { get; set; }

		
	}
}