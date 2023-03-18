using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grubbin : Pokemon
	{
		public override string Name => "Grubbin";
		public override List<Ability> AvailableAbilities => new() {new Swarm() };
		public override Stats BaseStats => new Stats(47, 62, 45, 46, 55, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
