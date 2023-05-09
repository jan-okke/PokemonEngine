using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Karrablast : Pokemon
{
	public override string Name => "Karrablast";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Noguard() };
	public override Stats BaseStats => new Stats(50, 75, 45, 40, 45, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Furycutter() },
		[8] = new List<Move>() { new Moves.Endure() },
		[12] = new List<Move>() { new Moves.Falseswipe() },
		[16] = new List<Move>() { new Moves.Acidspray() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Flail() },
		[28] = new List<Move>() { new Moves.Scaryface() },
		[32] = new List<Move>() { new Moves.Xscissor() },
		[36] = new List<Move>() { new Moves.Swordsdance() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[44] = new List<Move>() { new Moves.Bugbuzz() },
		[48] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bugbuzz(), new Moves.Drillrun(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Megahorn(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Counter(), new Moves.Knockoff(), new Moves.Nightslash(), new Moves.Slash() };
	public override int Weight => 59;
	public override int ExpYield => 63;
	public override int CatchRate => 200;
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