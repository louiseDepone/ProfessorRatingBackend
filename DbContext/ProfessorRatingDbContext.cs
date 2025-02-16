using ProfessorRating.Model;

namespace ProfessorRating.DbContext;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProfessorRatingDbContext(DbContextOptions<ProfessorRatingDbContext> options) : DbContext(options)
{

    public DbSet<Role> Role => Set<Role>();
    public DbSet<User> User => Set<User>();
    public DbSet<Teacher> Teacher => Set<Teacher>();
    public DbSet<School> School => Set<School>();
    public DbSet<Course> Course => Set<Course>();
    public DbSet<Department> Department => Set<Department>();
    public DbSet<CourseLecturer> CourseLecturer => Set<CourseLecturer>();
    public DbSet<Faculty> Faculty => Set<Faculty>();
    public DbSet<PinnedRate> PinnedRate => Set<PinnedRate>();
    public DbSet<Rate> Rate => Set<Rate>();
    public DbSet<SchoolDepartment> SchoolDepartment => Set<SchoolDepartment>();
    
}
