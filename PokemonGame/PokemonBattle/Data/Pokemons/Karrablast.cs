using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Karrablast : Pokemon
	{
		public override string Name => "Karrablast";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(50, 75, 45, 60, 40, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
