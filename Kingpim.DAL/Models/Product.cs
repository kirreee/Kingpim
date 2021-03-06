﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kingpim.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPublished { get; set; }
        public List<File> Files { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public int SubcategoryId { get; set; }
        public virtual SystemAttribute SystemAttribute { get; set; }
        public int SystemAttributeId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
