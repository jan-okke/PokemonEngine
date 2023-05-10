using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Swablu : Pokemon
{
	public override string Name => "Swablu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cloudnine() };
	public override Stats BaseStats => new Stats(45, 40, 60, 40, 75, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Disarmingvoice() },
		[8] = new List<Move>() { new Moves.Mist() },
		[12] = new List<Move>() { new Moves.Furyattack() },
		[16] = new List<Move>() { new Moves.Round() },
		[20] = new List<Move>() { new Moves.Dragonbreath() },
		[24] = new List<Move>() { new Moves.Safeguard() },
		[28] = new List<Move>() { new Moves.Sing() },
		[32] = new List<Move>() { new Moves.Cottonguard() },
		[36] = new List<Move>() { new Moves.Takedown() },
		[40] = new List<Move>() { new Moves.Moonblast() },
		[44] = new List<Move>() { new Moves.Perishsong() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fly(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Pluck(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Astonish(), new Moves.Dragonrush(), new Moves.Featherdance(), new Moves.Haze(), new Moves.Hypervoice(), new Moves.Playrough(), new Moves.Powerswap(), new Moves.Tailwind() };
	public override int Weight => 12;
	public override int ExpYield => 62;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}