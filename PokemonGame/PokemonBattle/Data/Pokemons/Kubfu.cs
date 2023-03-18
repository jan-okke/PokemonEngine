using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kubfu : Pokemon
	{
		public override string Name => "Kubfu";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(60, 90, 60, 72, 53, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
