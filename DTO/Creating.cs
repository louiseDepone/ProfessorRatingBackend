using System;

namespace ProfessorRating.DTO;

public class CreateSchoolDTO
{

    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int RoleId { get; set; }


}

public class CreateUserDTO()
{
    public string DisplayName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int RoleId { get; set; }
}

public class CreateDepartmentDTO
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
}
public class CreateRoleDTO
{
    public string Name { get; set; } = string.Empty;
}

public class CreateTeacherDTO
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
public class CreateCourseDTO
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
}

public class CreateCourseLecturerDTO
{
    public int CourseId { get; set; }
    public int TeacherId { get; set; }
}

public class CreateFacultyDTO
{
    public int TeacherId { get; set; }
    public int SchoolDepartmentId { get; set; }

}
public class CreateSchoolDepartmentDTO
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int SchoolId { get; set; }
}

// create rate
public class CreateRateDTO
{
    public int KnowledgeAndDelivery { get; set; }
    public int InterestAndStimulation { get; set; }
    public int ManagementAndOrganization { get; set; }
    public int StudentTeacherRelation { get; set; }
    public bool ToEnrollAgain { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public int Vote { get; set; }
    public string ClassMode { get; set; } = string.Empty;
    public int CourseLecturerId { get; set; }
    public int UserId { get; set; }
}

// pinned rate
public class CreatePinnedRateDTO
{
    public int RateId { get; set; }
    public int UserId { get; set; }
}