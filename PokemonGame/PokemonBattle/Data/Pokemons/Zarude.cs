using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zarude : Pokemon
	{
		public override string Name => "Zarude";
		public override List<Ability> AvailableAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(105, 120, 105, 105, 70, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Grass };
