using System.Collections.Generic;


namespace PierresTreats.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.JoinEntities = new HashSet<TreatFlavor>();
        }
        public int FlavorId { get; set; }
        public string Description { get; set; }
        public virtual Treat Treat { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<TreatFlavor> JoinEntities { get;}
    }
}