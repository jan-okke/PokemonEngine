using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Entities
{
    public class TextQueue
    {
        private List<string> Texts { get; set; }

        public TextQueue()
        {
            Texts = new();
        }
        public void Add(string text)
        {
            Texts.Add(text);
        }
        public bool HasNext()
        {
            return Texts.Count > 0;
        }
        public string Next()
        {
            if (!HasNext()) 
            {
                DebugConsole.WriteLine("Warning - TextQueue is empty!", ConsoleColor.Yellow);
                return default;
            }
            var text = Texts[0];
            Texts.Remove(text);
            return text;
        }
    }
}
