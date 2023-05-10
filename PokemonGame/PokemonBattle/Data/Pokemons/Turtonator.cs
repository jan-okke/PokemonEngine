using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Turtonator : Pokemon
{
	public override string Name => "Turtonator";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shellarmor() };
	public override Stats BaseStats => new Stats(60, 78, 135, 91, 85, 36);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Smog(), new Moves.Tackle() },
		[4] = new List<Move>() { new Moves.Ember() },
		[8] = new List<Move>() { new Moves.Protect() },
		[12] = new List<Move>() { new Moves.Endure() },
		[16] = new List<Move>() { new Moves.Flail() },
		[20] = new List<Move>() { new Moves.Incinerate() },
		[24] = new List<Move>() { new Moves.Irondefense() },
		[28] = new List<Move>() { new Moves.Dragonpulse() },
		[32] = new List<Move>() { new Moves.Bodyslam() },
		[36] = new List<Move>() { new Moves.Flamethrower() },
		[40] = new List<Move>() { new Moves.Shelltrap() },
		[44] = new List<Move>() { new Moves.Shellsmash() },
		[48] = new List<Move>() { new Moves.Overheat() },
		[52] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Burningjealousy(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Venoshock(), new Moves.Willowisp(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Headsmash(), new Moves.Rapidspin(), new Moves.Wideguard() };
	public override int Weight => 2120;
	public override int ExpYield => 170;
	public override int CatchRate => 70;
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