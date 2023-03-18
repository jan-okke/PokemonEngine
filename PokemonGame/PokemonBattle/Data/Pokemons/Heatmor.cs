using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Heatmor : Pokemon
	{
		public override string Name => "Heatmor";
		public override List<Ability> AvailableAbilities => new() {new Gluttony(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Whitesmoke() };
		public override Stats BaseStats => new Stats(85, 97, 66, 105, 66, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lick(), new Tackle() },
			[5] = new List<Move>() { new Furyswipes() },
			[10] = new List<Move>() { new Incinerate() },
			[15] = new List<Move>() { new Bugbite() },
			[20] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Bind() },
			[35] = new List<Move>() { new Firelash() },
			[40] = new List<Move>() { new Honeclaws() },
			[45] = new List<Move>() { new Amnesia() },
			[50] = new List<Move>() { new Firespin() },
			[55] = new List<Move>() { new Inferno() },
			[60] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Brutalswing(), new Burningjealousy(), new Dig(), new Drainpunch(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Gigadrain(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Lowkick(), new Overheat(), new Protect(), new Raindance(), new Rest(), new Rocktomb(), new Round(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Throatchop(), new Thunderpunch(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Curse(), new Nightslash(), new Suckerpunch(), new Tickle() };
		public override int Weight => 580;
		public override int ExpYield => 169;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}