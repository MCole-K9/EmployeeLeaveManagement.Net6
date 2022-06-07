﻿namespace EmployeeLeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
