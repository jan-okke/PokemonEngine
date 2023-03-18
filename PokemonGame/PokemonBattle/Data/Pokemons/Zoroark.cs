using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zoroark : Pokemon
	{
		public override string Name => "Zoroark";
		public override List<Ability> AvailableAbilities => new() {new Illusion() };
		public override Stats BaseStats => new Stats(60, 105, 60, 105, 120, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
