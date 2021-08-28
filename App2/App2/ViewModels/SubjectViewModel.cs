using System;
using System.Collections.Generic;
using System.Text;
using App2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace App2.ViewModels
{
    class SubjectViewModel
    {
        public Subject Subjects { get; set; }
        public SubjectViewModel()
        {
            Subjects = new Subject
            {
                Subjectcode = "PDC6",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
                Name = "Punsalang, Kenan kerl T",
                StudentID = "12-0083-975",
                DateAttendance = DateTime.Today,
            };
        }
    }
}
