using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shroomish : Pokemon
	{
		public override string Name => "Shroomish";
		public override List<Ability> AvailableAbilities => new() {new Effectspore(), new Poisonheal() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Quickfeet() };
		public override Stats BaseStats => new Stats(60, 40, 60, 35, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
