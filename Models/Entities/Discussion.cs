using System;

namespace Community_Application.Models
{
    public class Discussion
    {
        public int Id {get; set;}
        public string Subject {get; set;}
        public string Creator {get; set;}
        public DateTime TimeCreated {get; set;}
    }
}