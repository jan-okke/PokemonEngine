using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Axew : Pokemon
{
	public override string Name => "Axew";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rivalry(), new Abilities.Moldbreaker() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(46, 87, 60, 30, 40, 57);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer() },
		[3] = new List<Move>() { new Moves.Bite() },
		[6] = new List<Move>() { new Moves.Falseswipe() },
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
		[39] = new List<Move>() { new Moves.Swordsdance() },
		[42] = new List<Move>() { new Moves.Outrage() },
		[45] = new List<Move>() { new Moves.Guillotine() },
		[48] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Breakingswipe(), new Moves.Crunch(), new Moves.Dig(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Endeavor(), new Moves.Firstimpression(), new Moves.Harden(), new Moves.Nightslash() };
	public override int Weight => 180;
	public override int ExpYield => 64;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}