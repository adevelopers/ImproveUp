

namespace ImproveUp.Models
{

    using Interfaces;

    public partial class PatternInfo : IPatternInfo {

        public string name { get ;  }
        public string description { get; }

        public PatternInfo(string name) 
        {
            this.name = name;
            this.description = "";
        }

        public PatternInfo((string name, string description) tuple)
        {
            this.name = tuple.name;
            this.description = tuple.description;
                
        }

    }

    public partial class PatternInfo {

        public void print(IPrintableService service) 
        {
            service.print(this);
        }
    }

}