using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skiddo : Pokemon
	{
		public override string Name => "Skiddo";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Grasspelt() };
		public override Stats BaseStats => new Stats(66, 65, 48, 52, 62, 57);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
