using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Jangmo-o : Pokemon
	{
		public override string Name => "Jangmo-o";
		public override List<Ability> AvailableAbilities => new() {new Bulletproof(), new Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(45, 55, 65, 45, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[4] = new List<Move>() { new Protect() },
			[8] = new List<Move>() { new Dragontail() },
			[12] = new List<Move>() { new Scaryface() },
			[16] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Workup() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Irondefense() },
			[32] = new List<Move>() { new Dragonclaw() },
			[36] = new List<Move>() { new Nobleroar() },
			[40] = new List<Move>() { new Dragondance() },
			[44] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Irontail(), new Lowkick(), new Outrage(), new Payback(), new Protect(), new Rest(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Scaryface(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Swordsdance(), new Taunt(), new Uproar(), new Workup(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Dragonbreath(), new Focuspunch() };
		public override int Weight => 297;
		public override int ExpYield => 60;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}