using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Fraxure : Pokemon
	{
		public override string Name => "Fraxure";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(66, 117, 70, 40, 50, 67);
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
			[51] = new List<Move>() { new Guillotine() },
			[56] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Breakingswipe(), new Crunch(), new Dig(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Irontail(), new Lowkick(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Rocktomb(), new Round(), new Scaleshot(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Swordsdance(), new Taunt(), new Xscissor() };
		public override int Weight => 360;
		public override int ExpYield => 144;
		public override int CatchRate => 60;
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