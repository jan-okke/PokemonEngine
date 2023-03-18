using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kadabra : Pokemon
	{
		public override string Name => "Kadabra";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicguard() };
		public override Stats BaseStats => new Stats(40, 35, 30, 105, 120, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
