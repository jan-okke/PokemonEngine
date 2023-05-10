using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Paras : Pokemon
{
	public override string Name => "Paras";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Effectspore(), new Abilities.Dryskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Damp() };
	public override Stats BaseStats => new Stats(35, 70, 55, 45, 55, 25);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch() },
		[6] = new List<Move>() { new Moves.Stunspore(), new Moves.Poisonpowder() },
		[11] = new List<Move>() { new Moves.Absorb() },
		[17] = new List<Move>() { new Moves.Furycutter() },
		[22] = new List<Move>() { new Moves.Spore() },
		[27] = new List<Move>() { new Moves.Slash() },
		[33] = new List<Move>() { new Moves.Growth() },
		[38] = new List<Move>() { new Moves.Gigadrain() },
		[43] = new List<Move>() { new Moves.Aromatherapy() },
		[49] = new List<Move>() { new Moves.Ragepowder() },
		[54] = new List<Move>() { new Moves.Xscissor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Afteryou(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbite(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Knockoff(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thief(), new Moves.Venoshock(), new Moves.Worryseed(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Bugbite(), new Moves.Counter(), new Moves.Crosspoison(), new Moves.Fellstinger(), new Moves.Flail(), new Moves.Grassyterrain(), new Moves.Leechseed(), new Moves.Metalclaw(), new Moves.Psybeam(), new Moves.Screech(), new Moves.Sweetscent(), new Moves.Wideguard() };
	public override int Weight => 54;
	public override int ExpYield => 57;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}