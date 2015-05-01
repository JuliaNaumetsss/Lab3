using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Thriller : Grown
    {
        private string budget;
        public string Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public Thriller()
        {
            //this.budget = "5465la";
            
        }
       /* public void setBudget(string budget)
        {
            this.budget = budget;
        }
        public string getBudget()
        {
            return budget;
        }*/
    }
    
}
