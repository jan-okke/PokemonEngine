using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gourgeist : Pokemon
	{
		public override string Name => "Gourgeist";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Frisk() };
		public override Stats BaseStats => new Stats(55, 85, 122, 99, 58, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
