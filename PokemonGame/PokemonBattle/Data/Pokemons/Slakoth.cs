using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Slakoth : Pokemon
	{
		public override string Name => "Slakoth";
		public override List<Ability> AvailableAbilities => new() {new Truant() };
		public override Stats BaseStats => new Stats(60, 60, 60, 30, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
