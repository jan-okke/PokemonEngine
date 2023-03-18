using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kecleon : Pokemon
	{
		public override string Name => "Kecleon";
		public override List<Ability> AvailableAbilities => new() {new Colorchange() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Protean() };
		public override Stats BaseStats => new Stats(60, 90, 70, 40, 60, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
