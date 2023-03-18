using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Maractus : Pokemon
	{
		public override string Name => "Maractus";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stormdrain() };
		public override Stats BaseStats => new Stats(75, 86, 67, 60, 106, 67);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
