using BackEndAssignment.Middleware;

namespace BackEndAssignment.Extensions
{
    public static class AppExtensions
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }


        public static void ErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }

        public static void BaseRunningExtension(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();


        }
    }
}
