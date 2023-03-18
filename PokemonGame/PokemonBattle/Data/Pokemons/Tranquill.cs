using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tranquill : Pokemon
	{
		public override string Name => "Tranquill";
		public override List<Ability> AvailableAbilities => new() {new Bigpecks(), new Superluck() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rivalry() };
		public override Stats BaseStats => new Stats(62, 77, 62, 65, 50, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
