using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Marshadow : Pokemon
	{
		public override string Name => "Marshadow";
		public override List<Ability> AvailableAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(90, 125, 80, 125, 90, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Ghost };
