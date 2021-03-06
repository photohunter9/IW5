﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IW5Gallery.DAL.Entities;

namespace IW5Gallery.BL.Models
{
    public class AlbumDetailModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? CoverPhotoId { get; set; }
        public ICollection<MiniatureModel> Images { get; set; }
    }
}
