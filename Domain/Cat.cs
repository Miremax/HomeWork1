using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cat
    {
        public Cat(int Age1)
        {
            Age = Age1;
        }
        public int Age { get; private set; }
        private int Health = 5;
        public void Feed()
        {
            Health += 1;
        }

        public void Punish()
        {
            Health -= 1;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == null)
                {
                    _name = value;
                }
            }
        }
       // public CatColor Color { get; set; }
        public CatColor Color = new CatColor();
        public string CurrentColor
        {
            get
            {

                if (Health < 5)
                {
                    return Color.SickColor;
                }
                else
                {
                    return Color.HealthyColor;
                }
            }
            set { }
        }



    }
}
