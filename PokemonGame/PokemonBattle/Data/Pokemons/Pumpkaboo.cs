using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pumpkaboo : Pokemon
	{
		public override string Name => "Pumpkaboo";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Frisk() };
		public override Stats BaseStats => new Stats(44, 66, 70, 56, 44, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
