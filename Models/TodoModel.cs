using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Models
{
    class TodoModel
    {
        private bool _isDone;
        private string _text;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool isDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
