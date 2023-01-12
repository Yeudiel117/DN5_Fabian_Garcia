using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.MembershipTypes
{
	public class MembershipType
	{
		public int Id { get; set; }

        [StringLength(100)]
        [Required]
		public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public double Cost { get; set; }
        
        public DateTime CreatedOn { get; set; }

        [DataType(DataType.Duration)]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Required(ErrorMessage = "Duration must be in number months (1-12)")]
        public int Duration { get; set; }
	}
}
