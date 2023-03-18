using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Runerigus : Pokemon
	{
		public override string Name => "Runerigus";
		public override List<Ability> AvailableAbilities => new() {new Wanderingspirit() };
		public override Stats BaseStats => new Stats(58, 95, 145, 30, 50, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Ghost };
