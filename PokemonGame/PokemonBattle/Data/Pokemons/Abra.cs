using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Abra : Pokemon
	{
		public override string Name => "Abra";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicguard() };
		public override Stats BaseStats => new Stats(25, 20, 15, 90, 105, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
