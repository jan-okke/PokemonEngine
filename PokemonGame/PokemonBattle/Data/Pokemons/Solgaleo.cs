using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Solgaleo : Pokemon
{
	public override string Name => "Solgaleo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Fullmetalbody() };
	public override Stats BaseStats => new Stats(137, 137, 107, 113, 89, 97);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Sunsteelstrike() },
		[1] = new List<Move>() { new Moves.Sunsteelstrike(), new Moves.Cosmicpower(), new Moves.Teleport(), new Moves.Metalclaw(), new Moves.Nobleroar() },
		[7] = new List<Move>() { new Moves.Ironhead() },
		[14] = new List<Move>() { new Moves.Metalsound() },
		[21] = new List<Move>() { new Moves.Zenheadbutt() },
		[28] = new List<Move>() { new Moves.Flashcannon() },
		[35] = new List<Move>() { new Moves.Morningsun() },
		[42] = new List<Move>() { new Moves.Crunch() },
		[49] = new List<Move>() { new Moves.Metalburst() },
		[56] = new List<Move>() { new Moves.Wildcharge() },
		[63] = new List<Move>() { new Moves.Solarbeam() },
		[70] = new List<Move>() { new Moves.Flareblitz() },
		[77] = new List<Move>() { new Moves.Wideguard() },
		[84] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Cosmicpower(), new Moves.Crunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Flashcannon(), new Moves.Focusblast(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Mysticalfire(), new Moves.Outrage(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicfangs(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trickroom(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 2300;
	public override int ExpYield => 340;
	public override int CatchRate => 45;
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