using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Honedge : Pokemon
	{
		public override string Name => "Honedge";
		public override List<Ability> AvailableAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(45, 80, 100, 28, 35, 37);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
