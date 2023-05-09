using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Melmetal : Pokemon
{
	public override string Name => "Melmetal";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ironfist() };
	public override Stats BaseStats => new Stats(135, 143, 143, 80, 65, 34);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Thunderpunch() },
		[1] = new List<Move>() { new Moves.Thunderpunch(), new Moves.Thundershock(), new Moves.Harden(), new Moves.Tailwhip(), new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Thunderwave() },
		[32] = new List<Move>() { new Moves.Acidarmor() },
		[40] = new List<Move>() { new Moves.Flashcannon() },
		[48] = new List<Move>() { new Moves.Megapunch() },
		[56] = new List<Move>() { new Moves.Protect() },
		[64] = new List<Move>() { new Moves.Discharge() },
		[72] = new List<Move>() { new Moves.Dynamicpunch() },
		[80] = new List<Move>() { new Moves.Superpower() },
		[88] = new List<Move>() { new Moves.Doubleironbash() },
		[96] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Darkestlariat(), new Moves.Earthquake(), new Moves.Electricterrain(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave() };
	public override int Weight => 8000;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}