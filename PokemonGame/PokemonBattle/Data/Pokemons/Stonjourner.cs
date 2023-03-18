using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stonjourner : Pokemon
	{
		public override string Name => "Stonjourner";
		public override List<Ability> AvailableAbilities => new() {new Powerspot() };
		public override Stats BaseStats => new Stats(100, 125, 135, 70, 20, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
