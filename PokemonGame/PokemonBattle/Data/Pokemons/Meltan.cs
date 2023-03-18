using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meltan : Pokemon
	{
		public override string Name => "Meltan";
		public override List<Ability> AvailableAbilities => new() {new Magnetpull() };
		public override Stats BaseStats => new Stats(46, 65, 65, 34, 55, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
