using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zweilous : Pokemon
	{
		public override string Name => "Zweilous";
		public override List<Ability> AvailableAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(72, 85, 70, 58, 65, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
