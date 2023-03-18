using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Castform : Pokemon
	{
		public override string Name => "Castform";
		public override List<Ability> AvailableAbilities => new() {new Forecast() };
		public override Stats BaseStats => new Stats(70, 70, 70, 70, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
