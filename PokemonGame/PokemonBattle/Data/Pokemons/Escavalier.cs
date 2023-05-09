using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Escavalier : Pokemon
{
	public override string Name => "Escavalier";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Shellarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(70, 135, 105, 60, 105, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Fellstinger(), new Moves.Endure(), new Moves.Flail(), new Moves.Scaryface(), new Moves.Takedown(), new Moves.Doubleedge(), new Moves.Peck(), new Moves.Leer(), new Moves.Furycutter(), new Moves.Quickguard() },
		[12] = new List<Move>() { new Moves.Falseswipe() },
		[16] = new List<Move>() { new Moves.Acidspray() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Reversal() },
		[28] = new List<Move>() { new Moves.Irondefense() },
		[32] = new List<Move>() { new Moves.Xscissor() },
		[36] = new List<Move>() { new Moves.Swordsdance() },
		[40] = new List<Move>() { new Moves.Ironhead() },
		[44] = new List<Move>() { new Moves.Bugbuzz() },
		[48] = new List<Move>() { new Moves.Gigaimpact() },
		[52] = new List<Move>() { new Moves.Metalburst() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bugbuzz(), new Moves.Closecombat(), new Moves.Drillrun(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Focusblast(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megahorn(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Xscissor() };
	public override int Weight => 330;
	public override int ExpYield => 173;
	public override int CatchRate => 75;
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