using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Piplup : Pokemon
{
	public override string Name => "Piplup";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(53, 51, 53, 61, 56, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound() },
		[4] = new List<Move>() { new Moves.Growl() },
		[6] = new List<Move>() { new Moves.Watergun() },
		[11] = new List<Move>() { new Moves.Charm() },
		[15] = new List<Move>() { new Moves.Peck() },
		[18] = new List<Move>() { new Moves.Bubblebeam() },
		[22] = new List<Move>() { new Moves.Swagger() },
		[25] = new List<Move>() { new Moves.Furyattack() },
		[29] = new List<Move>() { new Moves.Brine() },
		[32] = new List<Move>() { new Moves.Whirlpool() },
		[36] = new List<Move>() { new Moves.Mist() },
		[39] = new List<Move>() { new Moves.Drillpeck() },
		[43] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Defog(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Pluck(), new Moves.Protect(), new Moves.Quash(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Aquaring(), new Moves.Doublehit(), new Moves.Featherdance(), new Moves.Flail(), new Moves.Hydropump(), new Moves.Icywind(), new Moves.Mudslap(), new Moves.Snore(), new Moves.Supersonic(), new Moves.Yawn() };
	public override int Weight => 52;
	public override int ExpYield => 63;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}