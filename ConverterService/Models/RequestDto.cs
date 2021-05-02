using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MagnitudeConverter.Models
{
    public class RequestDto
    {
        [Required]
        public string FromUnit { get; set; }

        [Required]
        public string ToUnit { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int EnteredValue { get; set; }

        public int ResultValue { get; set; }

    }
}
