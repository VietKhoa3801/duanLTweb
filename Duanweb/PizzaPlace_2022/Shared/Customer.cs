using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace_2022.Shared {
    public class Customer {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên của bạn")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Vui lòng cung cấp đường với số nhà")]
        public string Street { get; set; } = default!;
        [Required(ErrorMessage = "Vui lòng cung cấp tên thành phố")]
        public string City { get; set; } = default!;
    }
}
