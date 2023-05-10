using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Eternatus : Pokemon
{
	public override string Name => "Eternatus";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override Stats BaseStats => new Stats(140, 85, 95, 145, 95, 130);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Poisontail(), new Moves.Confuseray(), new Moves.Dragontail(), new Moves.Agility() },
		[8] = new List<Move>() { new Moves.Toxic() },
		[16] = new List<Move>() { new Moves.Venoshock() },
		[24] = new List<Move>() { new Moves.Dragondance() },
		[32] = new List<Move>() { new Moves.Crosspoison() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[48] = new List<Move>() { new Moves.Flamethrower() },
		[56] = new List<Move>() { new Moves.Dynamaxcannon() },
		[64] = new List<Move>() { new Moves.Cosmicpower() },
		[72] = new List<Move>() { new Moves.Recover() },
		[80] = new List<Move>() { new Moves.Hyperbeam() },
		[88] = new List<Move>() { new Moves.Eternabeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Brutalswing(), new Moves.Cosmicpower(), new Moves.Crosspoison(), new Moves.Dracometeor(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Mysticalfire(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock() };
	public override int Weight => 9500;
	public override int ExpYield => 345;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}