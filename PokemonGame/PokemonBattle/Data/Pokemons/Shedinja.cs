using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shedinja : Pokemon
	{
		public override string Name => "Shedinja";
		public override List<Ability> AvailableAbilities => new() {new Wonderguard() };
		public override Stats BaseStats => new Stats(1, 90, 45, 40, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Ghost };
