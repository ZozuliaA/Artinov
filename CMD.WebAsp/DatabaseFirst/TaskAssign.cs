//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskAssign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskAssign()
        {
            this.TaskAssignHistories = new HashSet<TaskAssignHistory>();
        }
    
        public System.Guid TaskAssignId { get; set; }
        public System.Guid UserId { get; set; }
        public System.Guid TaskId { get; set; }
        public string Comments { get; set; }
        public int StatusId { get; set; }
        public System.DateTime AssignData { get; set; }
        public System.DateTime CloseData { get; set; }
    
        public virtual Status Status { get; set; }
        public virtual Task Task { get; set; }
        public virtual TaskUser TaskUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignHistory> TaskAssignHistories { get; set; }
    }
}