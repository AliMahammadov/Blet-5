using System.ComponentModel.DataAnnotations.Schema;

namespace bilet55.View_Models.Team
{
    public class UpdateTeamVM
    {

        public String FullName { get; set; }
        public IFormFile img { get; set; }
        public string Position { get; set; }
        public string Thought { get; set; }
    }
}
