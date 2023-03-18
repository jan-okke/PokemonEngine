using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Urshifu : Pokemon
	{
		public override string Name => "Urshifu";
		public override List<Ability> AvailableAbilities => new() {new Unseenfist() };
		public override Stats BaseStats => new Stats(100, 130, 100, 97, 63, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Dark };
