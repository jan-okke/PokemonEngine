using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Amaura : Pokemon
	{
		public override string Name => "Amaura";
		public override List<Ability> AvailableAbilities => new() {new Refrigerate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Snowwarning() };
		public override Stats BaseStats => new Stats(77, 59, 50, 46, 67, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ice };
