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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Rivalry(), new Abilities.Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
		public override Stats BaseStats => new Stats(76, 147, 90, 60, 70, 97);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer(), new Moves.Bite(), new Moves.Falseswipe() },
			[9] = new List<Move>() { new Moves.Assurance() },
			[12] = new List<Move>() { new Moves.Taunt() },
			[15] = new List<Move>() { new Moves.Slash() },
			[18] = new List<Move>() { new Moves.Dragonclaw() },
			[21] = new List<Move>() { new Moves.Scaryface() },
			[24] = new List<Move>() { new Moves.Crunch() },
			[27] = new List<Move>() { new Moves.Dragondance() },
			[30] = new List<Move>() { new Moves.Dualchop() },
			[33] = new List<Move>() { new Moves.Laserfocus() },
			[36] = new List<Move>() { new Moves.Dragonpulse() },
			[41] = new List<Move>() { new Moves.Swordsdance() },
			[46] = new List<Move>() { new Moves.Outrage() },
			[53] = new List<Move>() { new Moves.Guillotine() },
			[60] = new List<Move>() { new Moves.Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Dig(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Xscissor() };
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