using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
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
		public override Stats BaseStats => new Stats(70, 110, 100, 50, 60, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Ironhead() },
			[1] = new List<Move>() { new Ironhead(), new Metalburst(), new Irondefense(), new Fakeout(), new Growl(), new Honeclaws(), new Scratch() },
			[12] = new List<Move>() { new Payday() },
			[16] = new List<Move>() { new Metalclaw() },
			[20] = new List<Move>() { new Taunt() },
			[24] = new List<Move>() { new Swagger() },
			[31] = new List<Move>() { new Furyswipes() },
			[36] = new List<Move>() { new Screech() },
			[42] = new List<Move>() { new Slash() },
			[48] = new List<Move>() { new Metalsound() },
			[54] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Assurance(), new Attract(), new Batonpass(), new Bodyslam(), new Closecombat(), new Crunch(), new Darkpulse(), new Dig(), new Endure(), new Facade(), new Fling(), new Foulplay(), new Gigaimpact(), new Gunkshot(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Nastyplot(), new Payback(), new Payday(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Round(), new Screech(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Steelbeam(), new Substitute(), new Sunnyday(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Covet(), new Curse(), new Doubleedge(), new Flail(), new Nightslash(), new Spite() };
		public override int Weight => 280;
		public override int ExpYield => 154;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}