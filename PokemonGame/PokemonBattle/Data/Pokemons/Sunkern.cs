using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sunkern : Pokemon
	{
		public override string Name => "Sunkern";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Solarpower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Earlybird() };
		public override Stats BaseStats => new Stats(30, 30, 30, 30, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
