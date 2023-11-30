using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book3._0
{
    internal class Magazine : Item
    {
        private string volume;
        private int number;
        private string title;
        private int year;
        
        public Magazine()
        {
            
        }

        public Magazine(string volume, int number, string title, int year, long inventoryNumber, bool taken) : base(inventoryNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public override string ToString()
        {
            return $"\nMagazine:\nVolume: {volume}\nNumber: {number}\nTitle: {title}\nPublished: {year}" + base.ToString();
        }

    }
}
