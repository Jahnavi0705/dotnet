﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MedicalERP.Models
{
    public partial class TblDoctorSpecialityDoctorMapping
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? CreateOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? IsDeleted { get; set; }
        public int? Dob { get; set; }
    }
}
