﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Seed
{
    public abstract class BaseEntity<T> where T :BaseAuditModel
    {
        public Guid Id { get; protected set; }
        public bool IsActive { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public abstract T MapToModel();
        public abstract T MapToModel(T t);
        public BaseEntity(T auditModel)
        {
            Id = auditModel.Id;
            CreatedDate = auditModel.CreatedDate;
            IsActive = auditModel.IsActive;
        }
        public BaseEntity()
        {

        }
    }
}
