using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Doublade : Pokemon
	{
		public override string Name => "Doublade";
		public override List<Ability> AvailableAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(59, 110, 150, 35, 45, 49);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
