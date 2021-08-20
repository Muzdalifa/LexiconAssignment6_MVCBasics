using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconAssignment6_MVCBasics.Models
{
    public class Utility
    {    
        public float Temperature { get; set; }
        public string HighFever
        {
            get
            {
                return "You have high fever";
            }
        }
        public string LowFever
        {
            get
            {
                return "You have low fever";
            }
        }
        public string NoFever
        {
            get
            {
                return "You have no fever";
            }
        }

        public string LowTemperature
        {
            get
            {
                return "You have low temperature";
            }
        }

        public static string CheckFever(float temp)
        {
            Utility utility = new Utility();
            if(temp > 39)
            {
                return utility.HighFever;
            }
            else if(temp >= 38)
            {
                return utility.LowFever;
            }
            else if (temp > 36 && temp <=37.9)
            {
                return utility.NoFever;
            }
            else
            {
                return utility.LowTemperature;
            }
        }
    }
}
