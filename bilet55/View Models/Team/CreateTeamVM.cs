using System.ComponentModel.DataAnnotations.Schema;

namespace bilet55.View_Models.Team
{
    public class CreateTeamVM
    {
        public string FullName { get; set; }
        public IFormFile img { get; set; }
        public string Position { get; set; }
        public string Thought { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
  