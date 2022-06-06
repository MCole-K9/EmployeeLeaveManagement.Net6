namespace EmployeeLeaveManagement.Web.Data
{
    public partial class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
    }
}
