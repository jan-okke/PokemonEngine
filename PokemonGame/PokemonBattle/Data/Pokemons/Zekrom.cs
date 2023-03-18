using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zekrom : Pokemon
	{
		public override string Name => "Zekrom";
		public override List<Ability> AvailableAbilities => new() {new Teravolt() };
		public override Stats BaseStats => new Stats(100, 150, 120, 90, 120, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Electric };
