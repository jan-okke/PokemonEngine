using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Komala : Pokemon
	{
		public override string Name => "Komala";
		public override List<Ability> AvailableAbilities => new() {new Comatose() };
		public override Stats BaseStats => new Stats(65, 115, 65, 65, 75, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
