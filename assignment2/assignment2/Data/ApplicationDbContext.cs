﻿using System;
using System.Collections.Generic;
using System.Text;
using assignment2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace assignment2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coach> Coach { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleMembers> ScheduleMembers { get; set; }
        public virtual DbSet<Enrolments> Enrolments { get; set; }
    }
}
