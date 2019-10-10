using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Data;
using assignment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace assignment2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Enrolments.Any())
                {
                    return;   // DB has been seeded
                }

                context.Enrolments.AddRange(
                    new Enrolments
                    {
                        memberId = 30,
                        scheduleId = 31
                    },
                    new Enrolments
                    {
                        memberId = 27,
                        scheduleId = 32
                    }
                    );
            }

        }
    }
}