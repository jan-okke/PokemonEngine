using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mimikyu : Pokemon
	{
		public override string Name => "Mimikyu";
		public override List<Ability> AvailableAbilities => new() {new Disguise() };
		public override Stats BaseStats => new Stats(55, 90, 80, 96, 50, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Fairy };
