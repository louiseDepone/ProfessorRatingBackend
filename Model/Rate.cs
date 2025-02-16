using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorRating.Model;

public class Rate
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public int KnowledgeAndDelivery { get; set; }
    public int InterestAndStimulation { get; set; }
    public int ManagementAndOrganization { get; set; }
    public int StudentTeacherRelation { get; set; }
    public bool ToEnrollAgain { get; set; }

    public string Title { get; set; }  = string.Empty;
    public string Content { get; set; }  = string.Empty;
    
    public int Vote { get; set; }
    public string ClassMode { get; set; }  = string.Empty;

    [ForeignKey("CourseLecturer")]
    public int CourseLecturerId { get; set; }
    public CourseLecturer? CourseLecturer { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }

    public User? User { get; set; }
    
    
}