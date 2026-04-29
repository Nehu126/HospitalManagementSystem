using System;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? Disease { get; set; }

        // 🔥 ADD THESE (your error fix)
        public string? Contact { get; set; }

        public DateTime VisitDate { get; set; }
    }
}