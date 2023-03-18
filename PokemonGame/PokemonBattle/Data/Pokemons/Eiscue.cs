using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eiscue : Pokemon
	{
		public override string Name => "Eiscue";
		public override List<Ability> AvailableAbilities => new() {new Iceface() };
		public override Stats BaseStats => new Stats(75, 80, 110, 50, 65, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
