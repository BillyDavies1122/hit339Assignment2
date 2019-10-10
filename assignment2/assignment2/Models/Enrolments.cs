using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment2.Models
{
    public class Enrolments
    {
        [Column("ID")]
        public int Id { get; set; }
        public int memberId { get; set; }
        public int scheduleId { get; set; }
    }
}
