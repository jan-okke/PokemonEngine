using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Heatmor : Pokemon
	{
		public override string Name => "Heatmor";
		public override List<Ability> AvailableAbilities => new() {new Gluttony(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Whitesmoke() };
		public override Stats BaseStats => new Stats(85, 97, 66, 65, 105, 66);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
