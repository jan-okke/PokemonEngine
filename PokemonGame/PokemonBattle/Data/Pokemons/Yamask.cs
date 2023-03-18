using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Yamask : Pokemon
	{
		public override string Name => "Yamask";
		public override List<Ability> AvailableAbilities => new() {new Mummy() };
		public override Stats BaseStats => new Stats(38, 30, 85, 30, 55, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
