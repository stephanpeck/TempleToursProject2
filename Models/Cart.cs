using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem (GroupInfo groupInfo, int qty)
        {
            //build a new instance of the object
            CartLine line = Lines
                .Where(b => b.GroupInfo.GroupInfoId == groupInfo.GroupInfoId)
                .FirstOrDefault();

            //didnt return any results in the list that matched (The item was Not already in their cart)
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    GroupInfo = groupInfo,
                    Quantity = qty
                });
            }
            //The item already was in their cart, so we are just going to add another of the quantity to that item
            else
            {
                line.Quantity += qty;
            }
        }


        //In C#, we can build a class within a class
        public class CartLine
        {
            public int CartLineID { get; set; }
            public GroupInfo GroupInfo { get; set; }
            public TimeSlots TimeSlots { get; set; }
            public int Quantity { get; set; }
        }

    }
}
