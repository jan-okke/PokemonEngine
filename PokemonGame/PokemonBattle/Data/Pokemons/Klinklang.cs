using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Klinklang : Pokemon
	{
		public override string Name => "Klinklang";
		public override List<Ability> AvailableAbilities => new() {new Plus(), new Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Clearbody() };
		public override Stats BaseStats => new Stats(60, 100, 115, 90, 70, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
