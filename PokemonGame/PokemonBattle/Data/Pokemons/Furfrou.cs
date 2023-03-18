using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Furfrou : Pokemon
	{
		public override string Name => "Furfrou";
		public override List<Ability> AvailableAbilities => new() {new Furcoat() };
		public override Stats BaseStats => new Stats(75, 80, 60, 102, 65, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
