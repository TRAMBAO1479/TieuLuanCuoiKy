using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlace_2022.Shared {
    public class Customer {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nhập tên của bạn ở đây nè!")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ!")]
        public string Street { get; set; } = default!;
        [Required(ErrorMessage = "Làm ơn nhập tên thành phố bạn đang sống")]
        public string City { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập SĐT")]
        public string SDT { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập ngày sinh của bạn!")]
        public string DOB { get; set; } = default!;
    }
}
