using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rayquaza : Pokemon
	{
		public override string Name => "Rayquaza";
		public override List<Ability> AvailableAbilities => new() {new Airlock() };
		public override Stats BaseStats => new Stats(105, 150, 90, 95, 150, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
