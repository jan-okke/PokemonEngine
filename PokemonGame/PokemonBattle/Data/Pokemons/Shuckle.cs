using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shuckle : Pokemon
{
	public override string Name => "Shuckle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Gluttony() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Contrary() };
	public override Stats BaseStats => new Stats(20, 10, 230, 10, 230, 5);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Withdraw(), new Moves.Wrap() },
		[5] = new List<Move>() { new Moves.Rollout() },
		[10] = new List<Move>() { new Moves.Strugglebug() },
		[15] = new List<Move>() { new Moves.Rockthrow() },
		[20] = new List<Move>() { new Moves.Safeguard() },
		[25] = new List<Move>() { new Moves.Rest() },
		[30] = new List<Move>() { new Moves.Bugbite() },
		[35] = new List<Move>() { new Moves.Powersplit(), new Moves.Guardsplit() },
		[40] = new List<Move>() { new Moves.Rockslide() },
		[45] = new List<Move>() { new Moves.Gastroacid() },
		[50] = new List<Move>() { new Moves.Stickyweb() },
		[55] = new List<Move>() { new Moves.Powertrick() },
		[60] = new List<Move>() { new Moves.Stoneedge() },
		[65] = new List<Move>() { new Moves.Shellsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelroller(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Toxic(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acid(), new Moves.Acupressure(), new Moves.Covet(), new Moves.Defensecurl(), new Moves.Finalgambit(), new Moves.Helpinghand(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Mudslap(), new Moves.Rockblast(), new Moves.Sandtomb(), new Moves.Sweetscent() };
	public override int Weight => 205;
	public override int ExpYield => 177;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}