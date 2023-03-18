using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pikipek : Pokemon
	{
		public override string Name => "Pikipek";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Skilllink() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickup() };
		public override Stats BaseStats => new Stats(35, 75, 30, 65, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
