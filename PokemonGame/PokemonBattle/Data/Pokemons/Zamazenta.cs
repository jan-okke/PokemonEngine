using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zamazenta : Pokemon
	{
		public override string Name => "Zamazenta";
		public override List<Ability> AvailableAbilities => new() {new Dauntlessshield() };
		public override Stats BaseStats => new Stats(92, 130, 115, 138, 80, 115);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
