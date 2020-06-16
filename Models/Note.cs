using System;
using System.ComponentModel.DataAnnotations;

namespace MVCNote.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime CreationTime { get; set; }
    }
}