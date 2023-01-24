using bilet55.Models.Base;

namespace bilet55.Models
{
    public class Profession:ProfessionNameBase
    {
        public ICollection<Team> Teams { get; set; }

    }
}
