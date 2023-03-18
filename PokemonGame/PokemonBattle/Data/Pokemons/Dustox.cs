using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dustox : Pokemon
	{
		public override string Name => "Dustox";
		public override List<Ability> AvailableAbilities => new() {new Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Compoundeyes() };
		public override Stats BaseStats => new Stats(60, 50, 70, 65, 50, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
