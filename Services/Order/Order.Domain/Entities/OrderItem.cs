﻿using Order.Domain.Models;
using Order.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Entities
{
    public class OrderItem : BaseEntity<OrderItemModel>
    {

        public OrderItem(OrderItemModel model):base(model)
        {
            Qty = model.Qty;
            Name = model.Name;
            Price = model.Price;
        }

        public decimal Qty { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

        public override OrderItemModel MapToModel()
        {
            OrderItemModel orderItemModel = new OrderItemModel(Qty,Name,Price);
            orderItemModel.CreatedDate = DateTime.UtcNow;
            orderItemModel.IsActive = true;
            return orderItemModel;
        }

        public override OrderItemModel MapToModel(OrderItemModel t)
        {
            throw new NotImplementedException();
        }
    }
}
