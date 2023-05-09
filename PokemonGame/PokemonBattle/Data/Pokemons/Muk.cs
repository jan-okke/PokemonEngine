using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Muk : Pokemon
{
	public override string Name => "Muk";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stench(), new Abilities.Stickyhold() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Poisontouch() };
	public override Stats BaseStats => new Stats(105, 105, 75, 65, 100, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Venomdrench() },
		[1] = new List<Move>() { new Moves.Venomdrench(), new Moves.Pound(), new Moves.Poisongas(), new Moves.Harden(), new Moves.Mudslap() },
		[4] = new List<Move>() { new Moves.Harden() },
		[7] = new List<Move>() { new Moves.Mudslap() },
		[12] = new List<Move>() { new Moves.Disable() },
		[15] = new List<Move>() { new Moves.Sludge() },
		[18] = new List<Move>() { new Moves.Smog() },
		[21] = new List<Move>() { new Moves.Minimize() },
		[26] = new List<Move>() { new Moves.Fling() },
		[29] = new List<Move>() { new Moves.Sludgebomb() },
		[32] = new List<Move>() { new Moves.Sludgewave() },
		[37] = new List<Move>() { new Moves.Screech() },
		[40] = new List<Move>() { new Moves.Gunkshot() },
		[46] = new List<Move>() { new Moves.Acidarmor() },
		[52] = new List<Move>() { new Moves.Belch() },
		[57] = new List<Move>() { new Moves.Memento() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Infestation(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Venoshock() };
	public override int Weight => 300;
	public override int ExpYield => 175;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}