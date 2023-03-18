using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wailmer : Pokemon
	{
		public override string Name => "Wailmer";
		public override List<Ability> AvailableAbilities => new() {new Waterveil(), new Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(130, 70, 35, 60, 70, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Water };
