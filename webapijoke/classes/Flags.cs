using System;
using System.Collections.Generic;
using System.Text;

namespace webapijoke.classes
{
    class Flags
    {
        public bool nsfw { get; set; }
        public bool religious { get; set; }
        public bool racist { get; set; }
        public bool sexist { get; set; }
        public bool political { get; set; }

        public string all()
        {
            return $"NSFW = {nsfw} Religious = {religious} Racist = {racist} Sexist = {sexist} Political = {political}";
        }
    }
}
