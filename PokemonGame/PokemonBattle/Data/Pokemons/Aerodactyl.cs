using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aerodactyl : Pokemon
	{
		public override string Name => "Aerodactyl";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(80, 105, 65, 130, 60, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
