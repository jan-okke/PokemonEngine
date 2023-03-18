using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Reshiram : Pokemon
	{
		public override string Name => "Reshiram";
		public override List<Ability> AvailableAbilities => new() {new Turboblaze() };
		public override Stats BaseStats => new Stats(100, 120, 100, 90, 150, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Fire };
