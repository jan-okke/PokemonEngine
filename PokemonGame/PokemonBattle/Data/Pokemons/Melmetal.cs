using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Melmetal : Pokemon
	{
		public override string Name => "Melmetal";
		public override List<Ability> AvailableAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(135, 143, 143, 34, 80, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
