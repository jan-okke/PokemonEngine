using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zygarde : Pokemon
	{
		public override string Name => "Zygarde";
		public override List<Ability> AvailableAbilities => new() {new Aurabreak(), new Powerconstruct() };
		public override Stats BaseStats => new Stats(108, 100, 121, 95, 81, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thousandarrows(), new Thousandwaves(), new Coreenforcer(), new Bind(), new Bulldoze(), new Dragonbreath(), new Bite() },
			[8] = new List<Move>() { new Haze() },
			[16] = new List<Move>() { new Dig() },
			[24] = new List<Move>() { new Safeguard() },
			[32] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Dragonpulse() },
			[48] = new List<Move>() { new Landswrath() },
			[56] = new List<Move>() { new Glare() },
			[64] = new List<Move>() { new Sandstorm() },
			[72] = new List<Move>() { new Coil() },
			[80] = new List<Move>() { new Earthquake() },
			[88] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Bulldoze(), new Crunch(), new Dig(), new Dracometeor(), new Dragondance(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Outrage(), new Payback(), new Protect(), new Rest(), new Retaliate(), new Reversal(), new Rockslide(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Scorchingsands(), new Skittersmack(), new Sleeptalk(), new Sludgewave(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Zenheadbutt() };
		public override int Weight => 3050;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
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