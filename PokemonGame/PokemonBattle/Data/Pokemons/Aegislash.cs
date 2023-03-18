using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aegislash : Pokemon
	{
		public override string Name => "Aegislash";
		public override List<Ability> AvailableAbilities => new() {new Stancechange() };
		public override Stats BaseStats => new Stats(60, 50, 140, 60, 50, 140);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ghost };
