using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magearna : Pokemon
	{
		public override string Name => "Magearna";
		public override List<Ability> AvailableAbilities => new() {new Soulheart() };
		public override Stats BaseStats => new Stats(80, 95, 115, 65, 130, 115);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
