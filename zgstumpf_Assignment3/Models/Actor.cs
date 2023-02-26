using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace zgstumpf_Assignment3.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? ImdbHyperlink { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
