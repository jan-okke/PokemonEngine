using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Corviknight : Pokemon
	{
		public override string Name => "Corviknight";
		public override List<Ability> AvailableAbilities => new() {new Pressure(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Mirrorarmor() };
		public override Stats BaseStats => new Stats(98, 87, 105, 67, 53, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Steel };
