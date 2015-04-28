using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Children_s : Film
    {
        protected string voiceOfTheFilm;
        public string VoiceOfTheFilm
        {
            get { return voiceOfTheFilm; }
            set { voiceOfTheFilm = value; }
        }
        public Children_s()
        {
        }
       /* public void setVoiceOfTheFilm(string voice)
        {
            this.voiceOfTheFilm = voice;
        }
        public string getVoiceOfTheFilm()
        {
            return voiceOfTheFilm;
        }*/
    }
}
