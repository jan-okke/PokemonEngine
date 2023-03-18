using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Minior : Pokemon
	{
		public override string Name => "Minior";
		public override List<Ability> AvailableAbilities => new() {new Shieldsdown() };
		public override Stats BaseStats => new Stats(60, 60, 100, 60, 60, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
