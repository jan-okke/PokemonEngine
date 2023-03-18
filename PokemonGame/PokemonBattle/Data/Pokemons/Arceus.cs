using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arceus : Pokemon
	{
		public override string Name => "Arceus";
		public override List<Ability> AvailableAbilities => new() {new Multitype() };
		public override Stats BaseStats => new Stats(120, 120, 120, 120, 120, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
