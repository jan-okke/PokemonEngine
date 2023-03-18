using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gothorita : Pokemon
	{
		public override string Name => "Gothorita";
		public override List<Ability> AvailableAbilities => new() {new Frisk(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shadowtag() };
		public override Stats BaseStats => new Stats(60, 45, 70, 55, 75, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
