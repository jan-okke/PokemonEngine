using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Scizor : Pokemon
{
	public override string Name => "Scizor";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Technician() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightmetal() };
	public override Stats BaseStats => new Stats(70, 130, 100, 55, 80, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Bulletpunch() },
		[1] = new List<Move>() { new Moves.Bulletpunch(), new Moves.Wingattack(), new Moves.Agility(), new Moves.Airslash(), new Moves.Quickattack(), new Moves.Leer(), new Moves.Furycutter(), new Moves.Falseswipe() },
		[12] = new List<Move>() { new Moves.Metalclaw() },
		[16] = new List<Move>() { new Moves.Doubleteam() },
		[20] = new List<Move>() { new Moves.Doublehit() },
		[24] = new List<Move>() { new Moves.Slash() },
		[28] = new List<Move>() { new Moves.Focusenergy() },
		[32] = new List<Move>() { new Moves.Irondefense() },
		[36] = new List<Move>() { new Moves.Ironhead() },
		[40] = new List<Move>() { new Moves.Xscissor() },
		[44] = new List<Move>() { new Moves.Laserfocus() },
		[48] = new List<Move>() { new Moves.Swordsdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bugbuzz(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelwing(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override int Weight => 1180;
	public override int ExpYield => 175;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}