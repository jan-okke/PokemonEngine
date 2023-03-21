using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Entities
{
    public class Trainer
    {
        public string Name { get; }
        public string IntroText { get; }
        public string LoseText { get; }

        public PokemonParty Party { get; }

        public Trainer(string name, string introText, string loseText, PokemonParty party) {
            Name = name;
            IntroText = introText;
            LoseText = loseText;
            Party = party;
        }

        public Trainer(string name, string introText, string loseText, Pokemon pokemon) {
            Name = name;
            IntroText = introText;
            LoseText = loseText;
            Party = new PokemonParty(pokemon);
        }

        public Trainer(string name, string introText, string loseText, List<Pokemon> pokemons) {
            Name = name;
            IntroText = introText;
            LoseText = loseText;
            Party = new PokemonParty(pokemons);
        }
    }
}