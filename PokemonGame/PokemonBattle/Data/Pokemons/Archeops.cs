using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Archeops : Pokemon
	{
		public override string Name => "Archeops";
		public override List<Ability> AvailableAbilities => new() {new Defeatist() };
		public override Stats BaseStats => new Stats(75, 140, 65, 110, 112, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
