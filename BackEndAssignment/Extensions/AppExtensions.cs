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
            /*
             Extra Points: Use a middleware to handle all the requests and the exceptions if any.
             */
            //app.UseMiddleware<ExceptionHandlerMiddleware>();
        }

        public static void BaseRunningExtension(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();


        }
    }
}
