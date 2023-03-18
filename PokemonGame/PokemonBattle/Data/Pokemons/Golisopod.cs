using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golisopod : Pokemon
	{
		public override string Name => "Golisopod";
		public override List<Ability> AvailableAbilities => new() {new Emergencyexit() };
		public override Stats BaseStats => new Stats(75, 125, 140, 40, 60, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
