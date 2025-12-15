using System;

namespace Api_TaskManagement
{
    public class TodoTask
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string description { get; set; }
    }
}