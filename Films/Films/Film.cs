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
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        protected int year;
        public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }
        protected string director;
        public void setDirector(string director)
        {
            this.director = director;
        }
        public string getDirector()
        {
            return director;
        }
        protected string producer;
        public void setProducer(string producer)
        {
            this.producer = producer;
        }
        public string getProducer()
        {
            return producer;
        }
        protected string feature;
        public void setFeature(string feature)
        {
            this.feature = feature;
        }
        public string getFeature()
        {
            return feature;
        }
    }
}
