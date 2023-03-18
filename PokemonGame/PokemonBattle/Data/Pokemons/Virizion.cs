using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Virizion : Pokemon
	{
		public override string Name => "Virizion";
		public override List<Ability> AvailableAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(91, 90, 72, 108, 90, 129);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fighting };
