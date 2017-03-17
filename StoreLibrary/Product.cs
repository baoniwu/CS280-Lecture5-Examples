using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Product
    {
        public string Name { get; set; }

        private int price;
        private float discount;

        public Product(string name, int price)
        {
            this.Price = price;
            this.Name = name;
            this.Discount = 1.0f;
        }

        public Product(string name, int price, float discount)
        {
            this.Price = price;
            this.Name = name;
            this.Discount = discount;
        }

        public Product()
        {
        }

        public int Price
        {
            get { return this.price; }

            set
            {
                if (value > 200)
                {
                    this.price = 200;
                }
                else if (value < 39)
                {
                    this.price = 39;
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public float Discount
        {
            //get => this.discount;
            get { return this.discount; }
            set
            {
                if (value > 1.0f)
                {
                    this.discount = 1.0f;
                }
                else if (value < 0.3f)
                {
                    this.discount = 0.3f;
                }
                else
                {
                    this.discount = value;
                }
            }
        }

        //public int GetPrice()
        //{
        //    return this.price;
        //}

        //public void SetPrice(int price)
        //{
        //    if (price > 200)
        //    {
        //        this.price = 200;
        //    }
        //    else if (price < 39)
        //    {
        //        this.price = 39;
        //    }
        //    else
        //    {
        //        this.price = price;
        //    }
        //}
    }
}