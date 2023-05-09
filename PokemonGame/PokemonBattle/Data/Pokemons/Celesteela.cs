using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Celesteela : Pokemon
{
	public override string Name => "Celesteela";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
	public override Stats BaseStats => new Stats(97, 101, 103, 107, 101, 61);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Harden() },
		[10] = new List<Move>() { new Moves.Wideguard() },
		[15] = new List<Move>() { new Moves.Megadrain() },
		[20] = new List<Move>() { new Moves.Smackdown() },
		[25] = new List<Move>() { new Moves.Ingrain() },
		[30] = new List<Move>() { new Moves.Autotomize() },
		[35] = new List<Move>() { new Moves.Gigadrain() },
		[40] = new List<Move>() { new Moves.Flashcannon() },
		[45] = new List<Move>() { new Moves.Metalsound() },
		[50] = new List<Move>() { new Moves.Irondefense() },
		[55] = new List<Move>() { new Moves.Leechseed() },
		[60] = new List<Move>() { new Moves.Heavyslam() },
		[65] = new List<Move>() { new Moves.Doubleedge() },
		[70] = new List<Move>() { new Moves.Skullbash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Airslash(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megahorn(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Zenheadbutt() };
	public override int Weight => 9999;
	public override int ExpYield => 285;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}