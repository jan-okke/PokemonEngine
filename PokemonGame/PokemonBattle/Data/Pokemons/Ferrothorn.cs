using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ferrothorn : Pokemon
	{
		public override string Name => "Ferrothorn";
		public override List<Ability> AvailableAbilities => new() {new Ironbarbs() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Anticipation() };
		public override Stats BaseStats => new Stats(74, 94, 131, 20, 54, 116);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
