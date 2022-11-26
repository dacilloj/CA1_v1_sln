using System.ComponentModel.DataAnnotations;

namespace CA1_v1.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string? Venue { get; set; }

        [StringLength(100, MinimumLength = 2)]
        public string? Opponent { get; set; }

        [Range(0, 100)]
        public int? GoalsFor { get; set; }

        [Range(0, 100)]
        public int? GoalsAgainst { get; set; }

    }
}
