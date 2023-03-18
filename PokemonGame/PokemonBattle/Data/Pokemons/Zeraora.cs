using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zeraora : Pokemon
	{
		public override string Name => "Zeraora";
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb() };
		public override Stats BaseStats => new Stats(88, 112, 75, 143, 102, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
