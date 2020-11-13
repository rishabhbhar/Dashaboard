using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashaboard.Models
{
    public class Dashboard
    {
        public int id { get; set; }
        [Display(Name = "#")]
        public int hashId { get; set; }
        [Display(Name = "Interview Name")]
        public string interviewName { get; set; }
        [Display(Name = "Skill Level")]
        public string skillLevel { get; set; }
        [Display(Name = "Assessment Modes")]
        public string assessmentModes { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        [Display(Name = "Questions")]
        public string questions { get; set; }

    }
}