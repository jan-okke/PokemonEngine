using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Volcanion : Pokemon
	{
		public override string Name => "Volcanion";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(80, 110, 120, 70, 130, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Water };
