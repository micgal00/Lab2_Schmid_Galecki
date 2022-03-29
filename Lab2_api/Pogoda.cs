using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_api
{
    public class Cord
    {
        public float lon;
        public float lat;
    }

    public class Weather
    {
        public int id;
        public string desc;
    }

    public class Main_part
    {
        public float temp;
        public float feels_like;
    }
    
    public class Wind
    {
        public float speed;
    }
}
