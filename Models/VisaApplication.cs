// /Models/VisaApplication.cs
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisaApplicationManager.Models
{


    public class VisaApplication
    {
        public int ApplicationId { get; set; }

        [Required]
        public string UserName { get; set; }

        // This will not be stored in the database, only the path
        [Display(Name = "Passport Copy")]
        public IFormFile PassportCopyFile { get; set; }

        public string PassportCopyPath { get; set; }

        [Required]
        public string VisaType { get; set; }

        [Required]
        public string CountryOfApplication { get; set; }

        [Required]
        public string ApplicationStatus { get; set; }

        public DateTime SubmissionDate { get; set; } = DateTime.Now;
    }
}