using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cherubi : Pokemon
	{
		public override string Name => "Cherubi";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override Stats BaseStats => new Stats(45, 35, 45, 35, 62, 53);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
