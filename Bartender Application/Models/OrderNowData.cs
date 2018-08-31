using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BartenderApplication.Models
{
    public class OrderNowData
    {
        public int OrderNo
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please enter your name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please choose a drink")]
        public string DrinkName { get; set; }

        [Required(ErrorMessage = "Please select how many drink(s)")]
        public int? DrinkQty { get; set; }

        [Required(ErrorMessage = "Please specify whether you want a double shot or not")]
        public bool? DoubleShot { get; set; }
    }
}
