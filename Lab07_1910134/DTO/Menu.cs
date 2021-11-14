using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_1910134.DTO
{
    public class Menu
    {
        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        
        public Menu(string foodName, int count, int price, int amount)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.Amount = amount;
        }
        public Menu(DataRow row)
        {
            this.FoodName = (string)row["Name"];
            this.Count = (int)row["Quantity"];
            this.Price = (int)row["Price"];
            this.Amount = (int)row["Amount"];
        }
    }
}
