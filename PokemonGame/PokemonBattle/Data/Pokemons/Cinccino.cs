using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cinccino : Pokemon
	{
		public override string Name => "Cinccino";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Skilllink() };
		public override Stats BaseStats => new Stats(75, 95, 60, 115, 65, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
