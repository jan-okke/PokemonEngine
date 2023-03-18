using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spectrier : Pokemon
	{
		public override string Name => "Spectrier";
		public override List<Ability> AvailableAbilities => new() {new Grimneigh() };
		public override Stats BaseStats => new Stats(100, 65, 60, 130, 145, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
