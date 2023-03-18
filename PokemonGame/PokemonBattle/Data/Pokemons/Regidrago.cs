using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regidrago : Pokemon
	{
		public override string Name => "Regidrago";
		public override List<Ability> AvailableAbilities => new() {new Dragonsmaw() };
		public override Stats BaseStats => new Stats(200, 100, 50, 80, 100, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
