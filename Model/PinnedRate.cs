using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorRating.Model;

public class PinnedRate
{
    public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    [ForeignKey("User")]
    public int UserId { get; set; }
    public User? User { get; set; }
    
    [ForeignKey("Rate")]
    public int RateId { get; set; }
    public Rate? Rate { get; set; }
    
    public List<PinnedRate> PinnedRates { get; set; } = new();

}