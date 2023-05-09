using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Raichu : Pokemon
{
	public override string Name => "Raichu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Static() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightningrod() };
	public override Stats BaseStats => new Stats(60, 90, 55, 90, 80, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Thunderpunch() },
		[1] = new List<Move>() { new Moves.Thunderpunch(), new Moves.Playnice(), new Moves.Sweetkiss(), new Moves.Nuzzle(), new Moves.Nastyplot(), new Moves.Charm(), new Moves.Thunderwave(), new Moves.Doubleteam(), new Moves.Electroball(), new Moves.Feint(), new Moves.Spark(), new Moves.Agility(), new Moves.Slam(), new Moves.Discharge(), new Moves.Thunderbolt(), new Moves.Lightscreen(), new Moves.Thunder(), new Moves.Thundershock(), new Moves.Tailwhip(), new Moves.Growl(), new Moves.Quickattack() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Risingvoltage(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 300;
	public override int ExpYield => 243;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}