using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Darkrai : Pokemon
	{
		public override string Name => "Darkrai";
		public override List<Ability> AvailableAbilities => new() {new Baddreams() };
		public override Stats BaseStats => new Stats(70, 90, 90, 125, 135, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
