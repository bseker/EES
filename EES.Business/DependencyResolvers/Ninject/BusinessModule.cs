

//using Mitras.Core.DataAccess.NHibernate;
 
using EES.Business.Abstract;
         
using EES.Business.Concrete;
         
using EES.DataLayer.Abstract;
using EES.DataLayer.Concrete.EntityFramework;

//using EES.DataLayer.Concrete.NHibernate;
         
//using EES.DataLayer.Concrete.NHibernate.Helpers;
         
using Ninject.Modules;

namespace EES.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDepartmentService>().To<DepartmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<EfDepartmentDal>().InSingletonScope();

            Bind<IEmployeeProjectService>().To<EmployeeProjectManager>().InSingletonScope();
            Bind<IEmployeeProjectDal>().To<EfEmployeeProjectDal>().InSingletonScope();
        
            Bind<IEmployeeRoleService>().To<EmployeeRoleManager>().InSingletonScope();
            Bind<IEmployeeRoleDal>().To<EfEmployeeRoleDal>().InSingletonScope();

            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();


            Bind<IEvaluationCommentService>().To<EvaluationCommentManager>().InSingletonScope();
            Bind<IEvaluationCommentDal>().To<EfEvaluationCommentDal>().InSingletonScope();

            Bind<IEvaluationQuestionListService>().To<EvaluationQuestionListManager>().InSingletonScope();
            Bind<IEvaluationQuestionListDal>().To<EfEvaluationQuestionListDal>().InSingletonScope();

            Bind<IEvaluationQuestionService>().To<EvaluationQuestionManager>().InSingletonScope();
            Bind<IEvaluationQuestionDal>().To<EfEvaluationQuestionDal>().InSingletonScope();

            Bind<IEvaluationService>().To<EvaluationManager>().InSingletonScope();
            Bind<IEvaluationDal>().To<EfEvaluationDal>().InSingletonScope();

            Bind<ILogTypeService>().To<LogTypeManager>().InSingletonScope();
            Bind<ILogTypeDal>().To<EfLogTypeDal>().InSingletonScope();

            Bind<IProjectService>().To<ProjectManager>().InSingletonScope();
            Bind<IProjectDal>().To<EfProjectDal>().InSingletonScope();

            Bind<IRoleService>().To<RoleManager>().InSingletonScope();
            Bind<IRoleDal>().To<EfRoleDal>().InSingletonScope();

            Bind<ISystemLogService>().To<SystemLogManager>().InSingletonScope();
            Bind<ISystemLogDal>().To<EfSystemLogDal>().InSingletonScope();

            Bind<ISystemModeService>().To<SystemModeManager>().InSingletonScope();
            Bind<ISystemModeDal>().To<EfSystemModeDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            /*
            Bind<NHibernateHelper>().To<SqlServerHelper>().InSingletonScope();
             
            Bind<IDepartmentService>().To<DepartmentManager>().InSingletonScope();
            Bind<IDepartmentDal>().To<NhDepartmentDal>().InSingletonScope();

         
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IEmployeeDal>().To<NhEmployeeDal>().InSingletonScope();

         
            Bind<IEmployeeProjectService>().To<EmployeeProjectManager>().InSingletonScope();
            Bind<IEmployeeProjectDal>().To<NhEmployeeProjectDal>().InSingletonScope();

         
            Bind<IEmployeeRoleService>().To<EmployeeRoleManager>().InSingletonScope();
            Bind<IEmployeeRoleDal>().To<NhEmployeeRoleDal>().InSingletonScope();

         
            Bind<IEvaluationService>().To<EvaluationManager>().InSingletonScope();
            Bind<IEvaluationDal>().To<NhEvaluationDal>().InSingletonScope();

         
            Bind<IEvaluationCommentService>().To<EvaluationCommentManager>().InSingletonScope();
            Bind<IEvaluationCommentDal>().To<NhEvaluationCommentDal>().InSingletonScope();

         
            Bind<IEvaluationQuestionListService>().To<EvaluationQuestionListManager>().InSingletonScope();
            Bind<IEvaluationQuestionListDal>().To<NhEvaluationQuestionListDal>().InSingletonScope();

         
            Bind<IEvaluationQuestionService>().To<EvaluationQuestionManager>().InSingletonScope();
            Bind<IEvaluationQuestionDal>().To<NhEvaluationQuestionDal>().InSingletonScope();

          
         
            Bind<ILogTypeService>().To<LogTypeManager>().InSingletonScope();
            Bind<ILogTypeDal>().To<NhLogTypeDal>().InSingletonScope();

         
            Bind<IProjectService>().To<ProjectManager>().InSingletonScope();
            Bind<IProjectDal>().To<NhProjectDal>().InSingletonScope();

         
            Bind<IRoleService>().To<RoleManager>().InSingletonScope();
            Bind<IRoleDal>().To<NhRoleDal>().InSingletonScope();

         
            Bind<ISystemLogService>().To<SystemLogManager>().InSingletonScope();
            Bind<ISystemLogDal>().To<NhSystemLogDal>().InSingletonScope();

         
            Bind<ISystemModeService>().To<SystemModeManager>().InSingletonScope();
            Bind<ISystemModeDal>().To<NhSystemModeDal>().InSingletonScope();

         
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<NhUserDal>().InSingletonScope();
            */
        }
    }
}