using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Torkoal : Pokemon
{
	public override string Name => "Torkoal";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Whitesmoke(), new Abilities.Drought() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Shellarmor() };
	public override Stats BaseStats => new Stats(70, 85, 140, 85, 70, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Smog(), new Moves.Ember() },
		[4] = new List<Move>() { new Moves.Withdraw() },
		[8] = new List<Move>() { new Moves.Rapidspin() },
		[12] = new List<Move>() { new Moves.Smokescreen() },
		[16] = new List<Move>() { new Moves.Clearsmog() },
		[20] = new List<Move>() { new Moves.Flamewheel() },
		[24] = new List<Move>() { new Moves.Protect() },
		[28] = new List<Move>() { new Moves.Lavaplume() },
		[32] = new List<Move>() { new Moves.Bodyslam() },
		[36] = new List<Move>() { new Moves.Irondefense() },
		[40] = new List<Move>() { new Moves.Flamethrower() },
		[44] = new List<Move>() { new Moves.Curse() },
		[48] = new List<Move>() { new Moves.Heatwave() },
		[52] = new List<Move>() { new Moves.Amnesia() },
		[56] = new List<Move>() { new Moves.Inferno() },
		[60] = new List<Move>() { new Moves.Shellsmash() },
		[64] = new List<Move>() { new Moves.Eruption() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Burningjealousy(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scorchingsands(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Weatherball(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Clearsmog(), new Moves.Eruption(), new Moves.Fissure(), new Moves.Flail(), new Moves.Skullbash(), new Moves.Superpower(), new Moves.Yawn() };
	public override int Weight => 804;
	public override int ExpYield => 165;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}