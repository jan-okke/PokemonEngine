using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Metapod : Pokemon
	{
		public override string Name => "Metapod";
		public override List<Ability> AvailableAbilities => new() {new Shedskin() };
		public override Stats BaseStats => new Stats(50, 20, 55, 30, 25, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
