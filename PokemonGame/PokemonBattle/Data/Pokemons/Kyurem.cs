using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kyurem : Pokemon
	{
		public override string Name => "Kyurem";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(125, 130, 90, 95, 130, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ice };
