using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Dto.ProductDto
{
    public class ProductOutputGetDto
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public bool Status { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int Quantity { get; set; }
        public long CategoryId { get; set; }
    }
}