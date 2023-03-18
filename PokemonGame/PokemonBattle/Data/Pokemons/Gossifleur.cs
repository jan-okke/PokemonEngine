using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gossifleur : Pokemon
	{
		public override string Name => "Gossifleur";
		public override List<Ability> AvailableAbilities => new() {new Cottondown(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Effectspore() };
		public override Stats BaseStats => new Stats(40, 40, 60, 10, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
