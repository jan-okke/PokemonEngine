using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Comfey : Pokemon
	{
		public override string Name => "Comfey";
		public override List<Ability> AvailableAbilities => new() {new Flowerveil(), new Triage() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Naturalcure() };
		public override Stats BaseStats => new Stats(51, 52, 90, 100, 82, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
