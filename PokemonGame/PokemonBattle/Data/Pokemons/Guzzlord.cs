using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Guzzlord : Pokemon
	{
		public override string Name => "Guzzlord";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(223, 101, 53, 97, 53, 43);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bite(), new Dragontail() },
			[5] = new List<Move>() { new Swallow(), new Stockpile() },
			[10] = new List<Move>() { new Knockoff() },
			[15] = new List<Move>() { new Stomp() },
			[20] = new List<Move>() { new Stompingtantrum() },
			[25] = new List<Move>() { new Wideguard() },
			[30] = new List<Move>() { new Crunch() },
			[35] = new List<Move>() { new Bodyslam() },
			[40] = new List<Move>() { new Gastroacid() },
			[45] = new List<Move>() { new Hammerarm() },
			[50] = new List<Move>() { new Heavyslam() },
			[55] = new List<Move>() { new Dragonrush() },
			[60] = new List<Move>() { new Belch() },
			[65] = new List<Move>() { new Thrash() },
			[70] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Corrosivegas(), new Crunch(), new Darkpulse(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Fling(), new Gigaimpact(), new Gyroball(), new Heatcrash(), new Heatwave(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Megakick(), new Megapunch(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snarl(), new Snore(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Thief() };
		public override int Weight => 8880;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}