using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Feebas : Pokemon
{
	public override string Name => "Feebas";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Oblivious() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Adaptability() };
	public override Stats BaseStats => new Stats(20, 15, 20, 10, 55, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Splash() },
		[15] = new List<Move>() { new Moves.Tackle() },
		[25] = new List<Move>() { new Moves.Flail() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Confuseray(), new Moves.Dragonbreath(), new Moves.Haze(), new Moves.Hypnosis(), new Moves.Mirrorcoat(), new Moves.Mist(), new Moves.Tickle() };
	public override int Weight => 74;
	public override int ExpYield => 40;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}