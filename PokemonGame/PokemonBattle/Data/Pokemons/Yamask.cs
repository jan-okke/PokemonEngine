using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Yamask : Pokemon
{
	public override string Name => "Yamask";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Mummy() };
	public override Stats BaseStats => new Stats(38, 30, 85, 55, 65, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Protect() },
		[4] = new List<Move>() { new Moves.Haze() },
		[8] = new List<Move>() { new Moves.Nightshade() },
		[12] = new List<Move>() { new Moves.Disable() },
		[16] = new List<Move>() { new Moves.Willowisp() },
		[20] = new List<Move>() { new Moves.Craftyshield() },
		[24] = new List<Move>() { new Moves.Hex() },
		[28] = new List<Move>() { new Moves.Meanlook() },
		[32] = new List<Move>() { new Moves.Grudge() },
		[36] = new List<Move>() { new Moves.Curse() },
		[40] = new List<Move>() { new Moves.Shadowball() },
		[44] = new List<Move>() { new Moves.Darkpulse() },
		[48] = new List<Move>() { new Moves.Powersplit(), new Moves.Guardsplit() },
		[52] = new List<Move>() { new Moves.Destinybond() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Thief(), new Moves.Toxicspikes(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Memento() };
	public override int Weight => 15;
	public override int ExpYield => 61;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}