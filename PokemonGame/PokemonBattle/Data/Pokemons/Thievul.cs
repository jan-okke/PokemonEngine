using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Thievul : Pokemon
	{
		public override string Name => "Thievul";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stakeout() };
		public override Stats BaseStats => new Stats(70, 58, 58, 90, 87, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
