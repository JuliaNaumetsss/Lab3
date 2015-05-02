using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Film
    {
        protected string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        
        protected int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        protected string director;
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        protected string producer;
        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }

        protected string feature;
        public string Feature
        {
            get { return feature; }
            set { feature = value; }
        }

        public Film()
        {
        }
    }
}
