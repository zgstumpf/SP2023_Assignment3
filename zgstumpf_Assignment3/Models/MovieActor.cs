using System.ComponentModel.DataAnnotations.Schema;

namespace zgstumpf_Assignment3.Models
{
    public class MovieActor
    {
        public Guid Id { get; set; }

        [ForeignKey("Movie")]
        public Guid? MovieId { get; set; }
        public Movie? Movie { get; set; }

        [ForeignKey("Actor")]
        public Guid? ActorId { get; set; }
        public Actor? Actor { get; set; }
    }
}
