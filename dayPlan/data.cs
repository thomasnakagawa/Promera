using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dayPlan
{
    class data
    {
        public string getData()
        {
            StreamReader file = new StreamReader("Data\\outputText.txt");
            string line;
            StringBuilder str = new StringBuilder();
            while((line = file.ReadLine()) != null)
            {
                str.Append(line + "\n");
            }
            return str.ToString();
        }
        class Activity
        {
            String name;
            String type;
            String distance;
            String budget;
            String activityLevel;
            String duration;
            String location;
            String childFriendly;
            
            public Activity(String name, String type, String distance, String budget, String activityLevel, String duration, String location, String childFriendly)
            {
                this.name = name;
                this.type = type;
                this.distance = distance;
                this.budget = budget;
                this.activityLevel = activityLevel;
                this.duration = duration;
                this.location = location;
                this.childFriendly = childFriendly;
            }
        }
    }
}
