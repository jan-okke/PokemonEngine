using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Klefki : Pokemon
	{
		public override string Name => "Klefki";
		public override List<Ability> AvailableAbilities => new() {new Prankster() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magician() };
		public override Stats BaseStats => new Stats(57, 80, 91, 75, 80, 87);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
