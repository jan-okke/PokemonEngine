using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Turtonator : Pokemon
	{
		public override string Name => "Turtonator";
		public override List<Ability> AvailableAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(60, 78, 135, 36, 91, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Dragon };
