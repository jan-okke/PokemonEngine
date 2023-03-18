using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chansey : Pokemon
	{
		public override string Name => "Chansey";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Healer() };
		public override Stats BaseStats => new Stats(250, 5, 5, 50, 35, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
