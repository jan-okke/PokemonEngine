using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eldegoss : Pokemon
	{
		public override string Name => "Eldegoss";
		public override List<Ability> AvailableAbilities => new() {new Cottondown(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Effectspore() };
		public override Stats BaseStats => new Stats(60, 50, 90, 60, 80, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
