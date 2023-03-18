using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Haxorus : Pokemon
	{
		public override string Name => "Haxorus";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(76, 147, 90, 97, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer(), new Bite(), new Falseswipe() },
			[9] = new List<Move>() { new Assurance() },
			[12] = new List<Move>() { new Taunt() },
			[15] = new List<Move>() { new Slash() },
			[18] = new List<Move>() { new Dragonclaw() },
			[21] = new List<Move>() { new Scaryface() },
			[24] = new List<Move>() { new Crunch() },
			[27] = new List<Move>() { new Dragondance() },
			[30] = new List<Move>() { new Dualchop() },
			[33] = new List<Move>() { new Laserfocus() },
			[36] = new List<Move>() { new Dragonpulse() },
			[41] = new List<Move>() { new Swordsdance() },
			[46] = new List<Move>() { new Outrage() },
			[53] = new List<Move>() { new Guillotine() },
			[60] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Closecombat(), new Crunch(), new Dig(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Lowkick(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Psychocut(), new Raindance(), new Rest(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Scaleshot(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swift(), new Swordsdance(), new Taunt(), new Xscissor() };
		public override int Weight => 1055;
		public override int ExpYield => 270;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}