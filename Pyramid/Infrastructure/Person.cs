using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid.Infrastructure
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Person
    {

        private string name, lastWorkplace, location;
        public Person(string name,string lastWorkplace,string location)
        {
            this.name = name;
            this.lastWorkplace = lastWorkplace;
            this.location = location;
        }

        [JsonProperty]
        public string Name 
        {
            get 
            {
                return name;
            }
            set 
            { 
                name = value;
            } 
        }

        [JsonProperty]
        public string LastWorkPlace 
        {
            get 
            { 
                return lastWorkplace;
            }
            set 
            { 
                lastWorkplace = value;
            } 
        }

        [JsonProperty]
        public string Location 
        { 
            get { return location; }
            set { location = value; }
        }
        
    }
}
