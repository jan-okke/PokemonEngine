using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cosmoem : Pokemon
	{
		public override string Name => "Cosmoem";
		public override List<Ability> AvailableAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(43, 29, 131, 37, 29, 131);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
