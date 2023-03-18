using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Walrein : Pokemon
	{
		public override string Name => "Walrein";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Oblivious() };
		public override Stats BaseStats => new Stats(110, 80, 90, 65, 95, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Water };
