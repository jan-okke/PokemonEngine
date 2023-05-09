using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Noibat : Pokemon
{
	public override string Name => "Noibat";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Frisk(), new Abilities.Infiltrator() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(40, 30, 35, 45, 40, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Absorb() },
		[4] = new List<Move>() { new Moves.Gust() },
		[8] = new List<Move>() { new Moves.Supersonic() },
		[12] = new List<Move>() { new Moves.Doubleteam() },
		[16] = new List<Move>() { new Moves.Wingattack() },
		[20] = new List<Move>() { new Moves.Bite() },
		[24] = new List<Move>() { new Moves.Aircutter() },
		[28] = new List<Move>() { new Moves.Whirlwind() },
		[32] = new List<Move>() { new Moves.Superfang() },
		[36] = new List<Move>() { new Moves.Airslash() },
		[40] = new List<Move>() { new Moves.Screech() },
		[44] = new List<Move>() { new Moves.Roost() },
		[49] = new List<Move>() { new Moves.Tailwind() },
		[52] = new List<Move>() { new Moves.Hurricane() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Darkpulse(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Leechlife(), new Moves.Outrage(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Wildcharge(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Defog(), new Moves.Dragonrush() };
	public override int Weight => 80;
	public override int ExpYield => 49;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}