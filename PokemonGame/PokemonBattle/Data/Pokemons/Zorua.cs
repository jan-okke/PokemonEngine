using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zorua : Pokemon
	{
		public override string Name => "Zorua";
		public override List<Ability> AvailableAbilities => new() {new Illusion() };
		public override Stats BaseStats => new Stats(40, 65, 40, 65, 80, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
