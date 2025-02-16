using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorRating.Model;

public class User
{
    public int Id { get; set; }
    public string DisplayName { get; set; }  = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    
    [ForeignKey("Role")]
    public int RoleId { get; set; }
    public Role? Role { get; set; } 
    
    public List<Rate> Rates { get; set; } = new();
    public List<PinnedRate> PinnedRates { get; set; } = new();
    
}