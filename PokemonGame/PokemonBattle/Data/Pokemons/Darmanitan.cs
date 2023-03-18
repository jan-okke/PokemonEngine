using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Darmanitan : Pokemon
	{
		public override string Name => "Darmanitan";
		public override List<Ability> AvailableAbilities => new() {new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Zenmode() };
		public override Stats BaseStats => new Stats(105, 140, 55, 95, 30, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
