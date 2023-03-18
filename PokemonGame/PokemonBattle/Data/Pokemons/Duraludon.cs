using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Duraludon : Pokemon
	{
		public override string Name => "Duraludon";
		public override List<Ability> AvailableAbilities => new() {new Lightmetal(), new Heavymetal() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stalwart() };
		public override Stats BaseStats => new Stats(70, 95, 115, 85, 120, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Dragon };
