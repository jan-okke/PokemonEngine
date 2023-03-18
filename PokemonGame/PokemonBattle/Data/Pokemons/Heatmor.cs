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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Gluttony(), new Abilities.Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Whitesmoke() };
		public override Stats BaseStats => new Stats(85, 97, 66, 105, 66, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Lick(), new Moves.Tackle() },
			[5] = new List<Move>() { new Moves.Furyswipes() },
			[10] = new List<Move>() { new Moves.Incinerate() },
			[15] = new List<Move>() { new Moves.Bugbite() },
			[20] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
			[25] = new List<Move>() { new Moves.Slash() },
			[30] = new List<Move>() { new Moves.Bind() },
			[35] = new List<Move>() { new Moves.Firelash() },
			[40] = new List<Move>() { new Moves.Honeclaws() },
			[45] = new List<Move>() { new Moves.Amnesia() },
			[50] = new List<Move>() { new Moves.Firespin() },
			[55] = new List<Move>() { new Moves.Inferno() },
			[60] = new List<Move>() { new Moves.Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Burningjealousy(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Overheat(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Curse(), new Moves.Nightslash(), new Moves.Suckerpunch(), new Moves.Tickle() };
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