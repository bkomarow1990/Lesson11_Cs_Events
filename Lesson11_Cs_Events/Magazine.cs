using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_Cs_Events
{
    delegate void NewPostAdded(string post);
    class Magazine
    {
        public event NewPostAdded NewPostAddedEvent;
        public void AddPost(string content) {
            posts.Add($"{DateTime.Now}\t {content}");
            NewPostAddedEvent?.Invoke(content);
        }
        public string Title { get; set; }
        List<string> posts = new List<string>();
        public override string ToString()
        {
            return $"Title: {Title}, Posts: {String.Join("\n\t", posts)}"; 
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public void Handler(string message) {
            Console.WriteLine($"Customer {Name} was notified about : {message}");
        }
    }
    class Worker
    {
        public static void Handler(string message) {
            Console.WriteLine($"All Workers was notified about: '{message}'");
        }
    }
}
