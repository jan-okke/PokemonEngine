using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cradily : Pokemon
	{
		public override string Name => "Cradily";
		public override List<Ability> AvailableAbilities => new() {new Suctioncups() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stormdrain() };
		public override Stats BaseStats => new Stats(86, 81, 97, 43, 81, 107);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Grass };
