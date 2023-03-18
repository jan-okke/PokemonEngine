using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Axew : Pokemon
	{
		public override string Name => "Axew";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(46, 87, 60, 30, 40, 57);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[3] = new List<Move>() { new Bite() },
			[6] = new List<Move>() { new Falseswipe() },
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
			[39] = new List<Move>() { new Swordsdance() },
			[42] = new List<Move>() { new Outrage() },
			[45] = new List<Move>() { new Guillotine() },
			[48] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Breakingswipe(), new Crunch(), new Dig(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Irontail(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Rocktomb(), new Round(), new Scaleshot(), new Scaryface(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Swordsdance(), new Taunt(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Endeavor(), new Firstimpression(), new Harden(), new Nightslash() };
		public override int Weight => 180;
		public override int ExpYield => 64;
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