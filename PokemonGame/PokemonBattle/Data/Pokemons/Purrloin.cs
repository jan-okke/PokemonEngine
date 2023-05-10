using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Purrloin : Pokemon
{
	public override string Name => "Purrloin";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Limber(), new Abilities.Unburden() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Prankster() };
	public override Stats BaseStats => new Stats(41, 50, 37, 50, 37, 66);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Sandattack() },
		[5] = new List<Move>() { new Moves.Fakeout() },
		[12] = new List<Move>() { new Moves.Furyswipes() },
		[16] = new List<Move>() { new Moves.Torment() },
		[21] = new List<Move>() { new Moves.Assurance() },
		[24] = new List<Move>() { new Moves.Honeclaws() },
		[28] = new List<Move>() { new Moves.Suckerpunch() },
		[32] = new List<Move>() { new Moves.Nastyplot() },
		[36] = new List<Move>() { new Moves.Nightslash() },
		[40] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Foulplay(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Uturn() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Copycat(), new Moves.Covet(), new Moves.Doubleteam(), new Moves.Quickattack(), new Moves.Slash(), new Moves.Yawn() };
	public override int Weight => 101;
	public override int ExpYield => 56;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}