using Microsoft.EntityFrameworkCore;
using HospitalAPI.Models;

namespace HospitalAPI.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }

        // هذا السطر هو الذي سينشئ جدول المرضى في قاعدة البيانات
        public DbSet<Patient> Patients { get; set; }
    }
}