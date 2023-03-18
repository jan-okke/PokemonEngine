using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Silvally : Pokemon
	{
		public override string Name => "Silvally";
		public override List<Ability> AvailableAbilities => new() {new Rkssystem() };
		public override Stats BaseStats => new Stats(95, 95, 95, 95, 95, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
