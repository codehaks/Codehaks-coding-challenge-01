﻿namespace WebApp.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
