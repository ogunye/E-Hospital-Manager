﻿using HIMS_Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Domain.Entities
{
    public class Appointment : AuditableBaseEntity
    {
        [ForeignKey(nameof(Patient))]
        public int PatientHealthCareNumber { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Principal Doctor is a required field.")]
        public string? Principal_Doctor { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage ="Appointment Status is a required field.")]
        public string? Appointment_Status { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage ="Appointment Description")]
        public string? Appointment_Description { get;set; }
    }
}
