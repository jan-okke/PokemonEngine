using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zacian : Pokemon
	{
		public override string Name => "Zacian";
		public override List<Ability> AvailableAbilities => new() {new Intrepidsword() };
		public override Stats BaseStats => new Stats(92, 130, 115, 138, 80, 115);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
