using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regigigas : Pokemon
	{
		public override string Name => "Regigigas";
		public override List<Ability> AvailableAbilities => new() {new Slowstart() };
		public override Stats BaseStats => new Stats(110, 160, 110, 100, 80, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
