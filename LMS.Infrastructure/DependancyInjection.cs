using LMS.Application.Data;
using LMS.Core.Repositories;
using LMS.Core.Repositories.Base;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories;
using LMS.Infrastructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace LMS.Infrastructure
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options
                    .UseSqlServer(configuration.GetConnectionString("lmsCS"),
                        b => {
                            b.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(5), errorNumbersToAdd: null);
                            b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
                            }));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options
            //        .UseSqlServer(configuration.GetConnectionString("lmsCS"),
            //            b => b.MigrationsAssembly("LMS.Infrastructure")));

            

            services.AddScoped<IApplicationDbContext>(options => options.GetRequiredService<ApplicationDbContext>());

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAdministratorRepository,AdministratorRepository>();

            services.AddScoped<IClassRepository, ClassesRepository>();

            services.AddScoped<IGradeRepository, GradeRepository>();

            services.AddScoped<IPrincipalRepository, PrincipleRepository>();

            services.AddScoped<IStudentRepository, StudentRepository>();

            services.AddScoped<ISubjectRepository, SubjectRepository>();

            services.AddScoped<ITeacherRepository, TeacherRepository>();

            return services;

        }
    }
}
