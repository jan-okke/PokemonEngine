using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Deino : Pokemon
	{
		public override string Name => "Deino";
		public override List<Ability> AvailableAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(52, 65, 50, 38, 45, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
