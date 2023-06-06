using exercise.api.Models;
using exercise.api.Repository;

namespace exercise.api.EndPoints
{
    public static class EmployeeAPI
    {
        public static void ConfigureEmployeeAPI(this WebApplication app)
        {
            app.MapGet("/Employees", GetEmployees);

        }

        private static async Task<IResult> GetEmployees(IDatabaseRepository<Employee> repository)
        {
            try
            {
                return Results.Ok(repository.Include(e => e.Salary));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    
    }
}
