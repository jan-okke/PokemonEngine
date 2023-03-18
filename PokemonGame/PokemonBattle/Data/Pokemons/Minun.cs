using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Minun : Pokemon
	{
		public override string Name => "Minun";
		public override List<Ability> AvailableAbilities => new() {new Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Voltabsorb() };
		public override Stats BaseStats => new Stats(60, 40, 50, 95, 75, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
