using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd_FLOWER_SHOP.Enums;

namespace BackEnd_FLOWER_SHOP.Entities
{
    public class ImageUpload
    {
        public long Id { get; set; }
        public string ImageUrl { get; set; }

        public string PublicId { get; set; }
        public long? ProductId { get; set; }
        public Product Product { get; set; }

    }
}