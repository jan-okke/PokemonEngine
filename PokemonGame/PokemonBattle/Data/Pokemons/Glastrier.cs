using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Glastrier : Pokemon
	{
		public override string Name => "Glastrier";
		public override List<Ability> AvailableAbilities => new() {new Chillingneigh() };
		public override Stats BaseStats => new Stats(100, 145, 130, 30, 65, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
