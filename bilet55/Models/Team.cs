using bilet55.Models.Base;
namespace bilet55.Models
{
    public class Team:BaseEntity
    {
        public string FullName { get; set; }
        public string ImgUrl { get; set; }
        public string Position { get; set; }
        public string Thought { get; set; }
        public string link { get; set; }

    }
}
