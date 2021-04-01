using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2FinalExam.Models
{
    public class QuoteInfo
    {
        [Key]
        public int QuoteID { get; set; }
        [Required]
        public string Quote { get; set; }
        [Required]
        public string AuthorSpeaker { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }

    }
}
