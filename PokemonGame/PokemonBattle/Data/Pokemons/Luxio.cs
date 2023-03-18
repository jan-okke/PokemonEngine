using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Luxio : Pokemon
	{
		public override string Name => "Luxio";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Guts() };
		public override Stats BaseStats => new Stats(60, 85, 49, 60, 60, 49);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
