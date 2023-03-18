using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zygarde : Pokemon
	{
		public override string Name => "Zygarde";
		public override List<Ability> AvailableAbilities => new() {new Aurabreak(), new Powerconstruct() };
		public override Stats BaseStats => new Stats(108, 100, 121, 95, 81, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
