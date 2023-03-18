using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Xerneas : Pokemon
	{
		public override string Name => "Xerneas";
		public override List<Ability> AvailableAbilities => new() {new Fairyaura() };
		public override Stats BaseStats => new Stats(126, 131, 95, 99, 131, 98);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
