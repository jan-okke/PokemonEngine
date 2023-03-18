using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Genesect : Pokemon
	{
		public override string Name => "Genesect";
		public override List<Ability> AvailableAbilities => new() {new Download() };
		public override Stats BaseStats => new Stats(71, 120, 95, 99, 120, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
