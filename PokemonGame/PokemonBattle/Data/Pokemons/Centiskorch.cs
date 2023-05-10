using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Centiskorch : Pokemon
{
	public override string Name => "Centiskorch";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire(), new Abilities.Whitesmoke() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flamebody() };
	public override Stats BaseStats => new Stats(100, 115, 65, 90, 90, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Inferno(), new Moves.Ember(), new Moves.Smokescreen(), new Moves.Wrap(), new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Flamewheel() },
		[20] = new List<Move>() { new Moves.Bugbite() },
		[25] = new List<Move>() { new Moves.Coil() },
		[32] = new List<Move>() { new Moves.Slam() },
		[39] = new List<Move>() { new Moves.Firespin() },
		[46] = new List<Move>() { new Moves.Crunch() },
		[53] = new List<Move>() { new Moves.Firelash() },
		[60] = new List<Move>() { new Moves.Lunge() },
		[67] = new List<Move>() { new Moves.Burnup() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bugbuzz(), new Moves.Crunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scorchingsands(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunderfang(), new Moves.Venoshock(), new Moves.Willowisp(), new Moves.Xscissor() };
	public override int Weight => 1200;
	public override int ExpYield => 184;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}