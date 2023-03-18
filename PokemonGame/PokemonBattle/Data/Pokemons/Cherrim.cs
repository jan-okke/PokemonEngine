using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cherrim : Pokemon
	{
		public override string Name => "Cherrim";
		public override List<Ability> AvailableAbilities => new() {new Flowergift() };
		public override Stats BaseStats => new Stats(70, 60, 70, 85, 87, 78);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
