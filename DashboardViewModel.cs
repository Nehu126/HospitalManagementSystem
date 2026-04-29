namespace HospitalManagementSystem.Models   // ⚠ use YOUR project namespace
{
    public class DashboardViewModel
    {
        public int TotalPatients { get; set; }
        public int TotalDoctors { get; set; }
        public int TotalAppointments { get; set; }

        public List<int> DailyPatients { get; set; } = new();
        public List<string> Days { get; set; } = new();
    }
}