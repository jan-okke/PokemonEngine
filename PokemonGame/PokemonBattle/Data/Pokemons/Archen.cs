using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Archen : Pokemon
	{
		public override string Name => "Archen";
		public override List<Ability> AvailableAbilities => new() {new Defeatist() };
		public override Stats BaseStats => new Stats(55, 112, 45, 70, 74, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
