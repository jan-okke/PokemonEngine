using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Oricorio : Pokemon
	{
		public override string Name => "Oricorio";
		public override List<Ability> AvailableAbilities => new() {new Dancer() };
		public override Stats BaseStats => new Stats(75, 70, 70, 93, 98, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
