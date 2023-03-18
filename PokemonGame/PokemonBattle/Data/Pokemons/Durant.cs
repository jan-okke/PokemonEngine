using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Durant : Pokemon
	{
		public override string Name => "Durant";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Truant() };
		public override Stats BaseStats => new Stats(58, 109, 112, 109, 48, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
