using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SuperS.Data.Model
{
    public class Receipt
    {
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
        public int ShoppingCartId { get; set; }
        public List<ShoppingItem> ShoppingItems { get; set; } = new List<ShoppingItem>();
        public decimal TotalPrice { get; set; }

        /*
        public decimal TotalPrice           //Property TotalPrice
        {
            get
            {
                return this.ShoppingItems.Count * this.ShoppingItems.Sum(i => i.Price);
            }
        }
        */
        public override string ToString()
        {
            return string.Format("Id:{0},TotalPrice:{1}", this.Id, this.TotalPrice);
        }
    }
}
