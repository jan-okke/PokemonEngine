using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Slaking : Pokemon
	{
		public override string Name => "Slaking";
		public override List<Ability> AvailableAbilities => new() {new Truant() };
		public override Stats BaseStats => new Stats(150, 160, 100, 100, 95, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
