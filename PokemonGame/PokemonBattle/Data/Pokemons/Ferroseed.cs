using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ferroseed : Pokemon
	{
		public override string Name => "Ferroseed";
		public override List<Ability> AvailableAbilities => new() {new Ironbarbs() };
		public override Stats BaseStats => new Stats(44, 50, 91, 10, 24, 86);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
