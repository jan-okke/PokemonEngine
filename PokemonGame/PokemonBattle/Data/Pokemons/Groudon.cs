using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Groudon : Pokemon
	{
		public override string Name => "Groudon";
		public override List<Ability> AvailableAbilities => new() {new Drought() };
		public override Stats BaseStats => new Stats(100, 150, 140, 90, 100, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
