using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gengar : Pokemon
	{
		public override string Name => "Gengar";
		public override List<Ability> AvailableAbilities => new() {new Cursedbody() };
		public override Stats BaseStats => new Stats(60, 65, 60, 110, 130, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Poison };
