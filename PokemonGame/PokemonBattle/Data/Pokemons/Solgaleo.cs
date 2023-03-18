using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Solgaleo : Pokemon
	{
		public override string Name => "Solgaleo";
		public override List<Ability> AvailableAbilities => new() {new Fullmetalbody() };
		public override Stats BaseStats => new Stats(137, 137, 107, 97, 113, 89);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Steel };
