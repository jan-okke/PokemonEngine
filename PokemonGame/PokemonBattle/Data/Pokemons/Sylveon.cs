using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sylveon : Pokemon
	{
		public override string Name => "Sylveon";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pixilate() };
		public override Stats BaseStats => new Stats(95, 65, 65, 60, 110, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
