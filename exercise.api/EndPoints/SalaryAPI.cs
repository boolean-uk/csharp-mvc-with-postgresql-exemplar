using exercise.api.Models;
using exercise.api.Repository;

namespace exercise.api.EndPoints
{
    public static class SalaryAPI
    {
        public static void ConfigureSalaryAPI(this WebApplication app)
        {
            app.MapGet("/Salaries", GetSalaries);

        }

        private static async Task<IResult> GetSalaries(IDatabaseRepository<Salary> repository)
        {
            try
            {
                return Results.Ok(repository.GetAll());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
