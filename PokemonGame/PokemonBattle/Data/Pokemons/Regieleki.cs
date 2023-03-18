using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regieleki : Pokemon
	{
		public override string Name => "Regieleki";
		public override List<Ability> AvailableAbilities => new() {new Transistor() };
		public override Stats BaseStats => new Stats(80, 100, 50, 200, 100, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
