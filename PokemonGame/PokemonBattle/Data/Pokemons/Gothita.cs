using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gothita : Pokemon
	{
		public override string Name => "Gothita";
		public override List<Ability> AvailableAbilities => new() {new Frisk(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shadowtag() };
		public override Stats BaseStats => new Stats(45, 30, 50, 45, 55, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
