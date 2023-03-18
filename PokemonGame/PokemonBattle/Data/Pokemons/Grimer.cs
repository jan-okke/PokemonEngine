using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grimer : Pokemon
	{
		public override string Name => "Grimer";
		public override List<Ability> AvailableAbilities => new() {new Stench(), new Stickyhold() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Poisontouch() };
		public override Stats BaseStats => new Stats(80, 80, 50, 25, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
