//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G1_SISAPP
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeachingAssignment
    {
        public string InstructorID { get; set; }
        public string CourseID { get; set; }
        public string TermID { get; set; }
    
        public virtual Courses Courses { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual StudyTerm StudyTerm { get; set; }
    }
}
