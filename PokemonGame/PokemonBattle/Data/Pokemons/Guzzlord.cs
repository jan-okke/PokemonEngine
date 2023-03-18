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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
		public override Stats BaseStats => new Stats(223, 101, 53, 97, 53, 43);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Bite(), new Moves.Dragontail() },
			[5] = new List<Move>() { new Moves.Swallow(), new Moves.Stockpile() },
			[10] = new List<Move>() { new Moves.Knockoff() },
			[15] = new List<Move>() { new Moves.Stomp() },
			[20] = new List<Move>() { new Moves.Stompingtantrum() },
			[25] = new List<Move>() { new Moves.Wideguard() },
			[30] = new List<Move>() { new Moves.Crunch() },
			[35] = new List<Move>() { new Moves.Bodyslam() },
			[40] = new List<Move>() { new Moves.Gastroacid() },
			[45] = new List<Move>() { new Moves.Hammerarm() },
			[50] = new List<Move>() { new Moves.Heavyslam() },
			[55] = new List<Move>() { new Moves.Dragonrush() },
			[60] = new List<Move>() { new Moves.Belch() },
			[65] = new List<Move>() { new Moves.Thrash() },
			[70] = new List<Move>() { new Moves.Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Corrosivegas(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snarl(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Thief() };
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