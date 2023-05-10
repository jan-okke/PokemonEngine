using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lotad : Pokemon
{
	public override string Name => "Lotad";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Raindish() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Owntempo() };
	public override Stats BaseStats => new Stats(40, 30, 30, 40, 50, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Growl() },
		[3] = new List<Move>() { new Moves.Absorb() },
		[6] = new List<Move>() { new Moves.Watergun() },
		[9] = new List<Move>() { new Moves.Mist() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[16] = new List<Move>() { new Moves.Flail() },
		[20] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Naturepower() },
		[28] = new List<Move>() { new Moves.Gigadrain() },
		[33] = new List<Move>() { new Moves.Raindance() },
		[38] = new List<Move>() { new Moves.Zenheadbutt() },
		[43] = new List<Move>() { new Moves.Energyball() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulletseed(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Flail(), new Moves.Leechseed(), new Moves.Razorleaf(), new Moves.Sweetscent(), new Moves.Synthesis(), new Moves.Teeterdance(), new Moves.Tickle(), new Moves.Watergun() };
	public override int Weight => 26;
	public override int ExpYield => 44;
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