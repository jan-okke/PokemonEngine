using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Stonjourner : Pokemon
{
	public override string Name => "Stonjourner";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Powerspot() };
	public override Stats BaseStats => new Stats(100, 125, 135, 20, 20, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rockthrow(), new Moves.Block() },
		[6] = new List<Move>() { new Moves.Rockpolish() },
		[12] = new List<Move>() { new Moves.Rocktomb() },
		[18] = new List<Move>() { new Moves.Gravity() },
		[24] = new List<Move>() { new Moves.Stomp() },
		[30] = new List<Move>() { new Moves.Stealthrock() },
		[36] = new List<Move>() { new Moves.Rockslide() },
		[42] = new List<Move>() { new Moves.Bodyslam() },
		[48] = new List<Move>() { new Moves.Wideguard() },
		[54] = new List<Move>() { new Moves.Heavyslam() },
		[60] = new List<Move>() { new Moves.Stoneedge() },
		[66] = new List<Move>() { new Moves.Megakick() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Megakick(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Wonderroom() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Curse() };
	public override int Weight => 5200;
	public override int ExpYield => 165;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}