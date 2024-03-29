﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Models
{
    public abstract class BaseModel
    {
        public Guid? Id { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public abstract T MapToEntity<T>() where T : class;
    }
}
