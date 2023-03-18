using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Deerling : Pokemon
	{
		public override string Name => "Deerling";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Serenegrace() };
		public override Stats BaseStats => new Stats(60, 60, 50, 75, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Grass };
