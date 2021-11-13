
using System.Data.Entity;
using EES.Entities.Concrete;
using EES.Entities.View;

namespace EES.DataLayer.Concrete.EntityFramework
{
    public class EesContext : DbContext
    {
        public EesContext()
        {
            Database.SetInitializer<EesContext>(null);
        }

        /*Tables*/

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<EvaluationComment> EvaluationComments { get; set; }
        public DbSet<EvaluationQuestion> EvaluationQuestions { get; set; }
        public DbSet<EvaluationQuestionList> EvaluationQuestionLists { get; set; }
        public DbSet<LogType> LogTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        public DbSet<SystemMode> SystemModes { get; set; }
        public DbSet<User> Users { get; set; }

        /*Views*/

        public DbSet<UserEmployeeView> UserEmployeeView { get; set; }

        public DbSet<EmployeeRoleView> EmployeeRoleViews { get; set; }

        public DbSet<EmployeeProjectView> EmployeeProjectViews { get; set; }

        public DbSet<EmployeeView> EmployeeViews { get; set; }

        public DbSet<EvaluationView> EvaluationViews { get; set; }

        public DbSet<EvaluationQuestionsView> EvaluationQuestionsViews { get; set; }

        public DbSet<QuestionRoleView> QuestionRoleViews { get; set; }
    }
}
