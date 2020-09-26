using System;
using System.Collections.Generic;
using System.Text;

namespace webapijoke.classes
{
    class Joke
    {
        public bool error { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string joke { get; set; }
        public Flags flags { get; set; }
        public int id { get; set; }
        public string lang { get; set; }

        public void Show()
        {
            Console.WriteLine($"ERRO : {error}." +
                              $"\nCategory : {category}." +
                              $"\nType : {type}" +
                              $"\nFlags : {flags.all()}" +
                              $"\nID : {id}" +
                              $"\nLang : {lang}");
            Console.WriteLine($"\n\n\nJoke : \n{joke}");
        }
    }
}
