using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Toxel : Pokemon
	{
		public override string Name => "Toxel";
		public override List<Ability> AvailableAbilities => new() {new Rattled(), new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Klutz() };
		public override Stats BaseStats => new Stats(40, 38, 35, 40, 54, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Poison };
