using System;

namespace MetroFramework_test_at_a_new_project.Data
{
        public class LogRecord
        {
            public string Message{get;set;}
            public DateTime DateTime{get;set;}
            public LogRecord(string message, DateTime? dateTime)
            {
                Message = message;
                DateTime = dateTime.HasValue? dateTime.Value : DateTime.Now;
            }
        }
}