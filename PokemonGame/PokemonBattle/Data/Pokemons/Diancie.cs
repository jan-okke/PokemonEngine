using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Diancie : Pokemon
	{
		public override string Name => "Diancie";
		public override List<Ability> AvailableAbilities => new() {new Clearbody() };
		public override Stats BaseStats => new Stats(50, 100, 150, 50, 100, 150);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fairy };
