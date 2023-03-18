using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Riolu : Pokemon
	{
		public override string Name => "Riolu";
		public override List<Ability> AvailableAbilities => new() {new Steadfast(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Prankster() };
		public override Stats BaseStats => new Stats(40, 70, 40, 60, 35, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Endure() },
			[4] = new List<Move>() { new Feint() },
			[8] = new List<Move>() { new Metalclaw() },
			[12] = new List<Move>() { new Counter() },
			[16] = new List<Move>() { new Workup() },
			[20] = new List<Move>() { new Rocksmash() },
			[24] = new List<Move>() { new Nastyplot() },
			[28] = new List<Move>() { new Screech() },
			[32] = new List<Move>() { new Quickguard() },
			[36] = new List<Move>() { new Forcepalm() },
			[40] = new List<Move>() { new Swordsdance() },
			[44] = new List<Move>() { new Helpinghand() },
			[48] = new List<Move>() { new Copycat() },
			[52] = new List<Move>() { new Finalgambit() },
			[56] = new List<Move>() { new Reversal() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Blazekick(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Coaching(), new Crunch(), new Dig(), new Doubleteam(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Irondefense(), new Irontail(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Nastyplot(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thunderpunch(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Bite(), new Blazekick(), new Bulletpunch(), new Circlethrow(), new Crosschop(), new Crunch(), new Detect(), new Followme(), new Highjumpkick(), new Howl(), new Irondefense(), new Lowkick(), new Meteormash(), new Mindreader(), new Vacuumwave() };
		public override int Weight => 202;
		public override int ExpYield => 57;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}