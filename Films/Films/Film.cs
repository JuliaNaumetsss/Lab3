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
        /*public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }*/
        protected int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
       /* public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }*/
        protected string director;
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
       /* public void setDirector(string director)
        {
            this.director = director;
        }
        public string getDirector()
        {
            return director;
        }*/
        protected string producer;
        public string Producer
        {
            get { return producer; }
            set { producer = value; }
        }
       /* public void setProducer(string producer)
        {
            this.producer = producer;
        }
        public string getProducer()
        {
            return producer;
        }*/
        protected string feature;
        public string Feature
        {
            get { return feature; }
            set { feature = value; }
        }
      /*  public void setFeature(string feature)
        {
            this.feature = feature;
        }
        public string getFeature()
        {
            return feature;
        }*/
    }
}
