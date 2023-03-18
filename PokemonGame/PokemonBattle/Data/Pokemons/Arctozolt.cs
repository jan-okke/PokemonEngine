using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arctozolt : Pokemon
	{
		public override string Name => "Arctozolt";
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb(), new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Slushrush() };
		public override Stats BaseStats => new Stats(90, 100, 90, 55, 90, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Ice };
