using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wimpod : Pokemon
	{
		public override string Name => "Wimpod";
		public override List<Ability> AvailableAbilities => new() {new Wimpout() };
		public override Stats BaseStats => new Stats(25, 35, 40, 80, 20, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
