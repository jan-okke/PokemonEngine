using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Scyther : Pokemon
{
	public override string Name => "Scyther";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Technician() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Steadfast() };
	public override Stats BaseStats => new Stats(70, 110, 80, 55, 80, 105);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Furycutter() },
		[8] = new List<Move>() { new Moves.Falseswipe() },
		[12] = new List<Move>() { new Moves.Wingattack() },
		[16] = new List<Move>() { new Moves.Doubleteam() },
		[20] = new List<Move>() { new Moves.Doublehit() },
		[24] = new List<Move>() { new Moves.Slash() },
		[28] = new List<Move>() { new Moves.Focusenergy() },
		[32] = new List<Move>() { new Moves.Agility() },
		[36] = new List<Move>() { new Moves.Airslash() },
		[40] = new List<Move>() { new Moves.Xscissor() },
		[44] = new List<Move>() { new Moves.Laserfocus() },
		[48] = new List<Move>() { new Moves.Swordsdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bugbuzz(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Uturn(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Batonpass(), new Moves.Counter(), new Moves.Feint(), new Moves.Nightslash(), new Moves.Quickguard(), new Moves.Reversal() };
	public override int Weight => 560;
	public override int ExpYield => 100;
	public override int CatchRate => 45;
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