using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arctovish : Pokemon
	{
		public override string Name => "Arctovish";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Slushrush() };
		public override Stats BaseStats => new Stats(90, 90, 100, 55, 80, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
