using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Blissey : Pokemon
	{
		public override string Name => "Blissey";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Healer() };
		public override Stats BaseStats => new Stats(255, 10, 10, 55, 75, 135);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
