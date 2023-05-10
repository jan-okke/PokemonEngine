using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lombre : Pokemon
{
	public override string Name => "Lombre";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Raindish() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Owntempo() };
	public override Stats BaseStats => new Stats(60, 50, 50, 60, 70, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Teeterdance(), new Moves.Fakeout(), new Moves.Knockoff(), new Moves.Flail(), new Moves.Astonish(), new Moves.Growl(), new Moves.Absorb(), new Moves.Watergun() },
		[9] = new List<Move>() { new Moves.Mist() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[18] = new List<Move>() { new Moves.Furyswipes() },
		[24] = new List<Move>() { new Moves.Bubblebeam() },
		[30] = new List<Move>() { new Moves.Naturepower() },
		[36] = new List<Move>() { new Moves.Gigadrain() },
		[43] = new List<Move>() { new Moves.Raindance() },
		[50] = new List<Move>() { new Moves.Zenheadbutt() },
		[57] = new List<Move>() { new Moves.Energyball() },
		[64] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override int Weight => 325;
	public override int ExpYield => 119;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}