﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.DAL.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public long Size{ get; set; }
        public virtual Advertisement Advertisement { get; set; }
        public int AdvertisementId { get; set; }

    }
}
