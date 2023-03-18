using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Perrserker : Pokemon
	{
		public override string Name => "Perrserker";
		public override List<Ability> AvailableAbilities => new() {new Battlearmor(), new Toughclaws() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steelyspirit() };
		public override Stats BaseStats => new Stats(70, 110, 100, 50, 50, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
