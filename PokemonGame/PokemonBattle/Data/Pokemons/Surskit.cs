using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Surskit : Pokemon
	{
		public override string Name => "Surskit";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(40, 30, 32, 50, 52, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun() },
			[6] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Sweetscent() },
			[14] = new List<Move>() { new Soak() },
			[17] = new List<Move>() { new Bubblebeam() },
			[22] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Mist(), new Haze() },
			[30] = new List<Move>() { new Aquajet() },
			[35] = new List<Move>() { new Batonpass() },
			[38] = new List<Move>() { new Stickyweb() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bugbite(), new Confide(), new Doubleteam(), new Endure(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Hiddenpower(), new Icebeam(), new Icywind(), new Infestation(), new Liquidation(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Scald(), new Shadowball(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Aquajet(), new Bugbite(), new Fellstinger(), new Hydropump(), new Lunge(), new Mindreader(), new Mudshot(), new Powersplit(), new Psybeam() };
		public override int Weight => 17;
		public override int ExpYield => 54;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}