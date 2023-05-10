using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tapufini : Pokemon
{
	public override string Name => "Tapu Fini";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Mistysurge() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(70, 75, 115, 95, 130, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Disarmingvoice(), new Moves.Watergun() },
		[5] = new List<Move>() { new Moves.Withdraw() },
		[10] = new List<Move>() { new Moves.Mist(), new Moves.Haze() },
		[15] = new List<Move>() { new Moves.Aquaring() },
		[20] = new List<Move>() { new Moves.Waterpulse() },
		[25] = new List<Move>() { new Moves.Brine() },
		[30] = new List<Move>() { new Moves.Defog() },
		[35] = new List<Move>() { new Moves.Healpulse() },
		[40] = new List<Move>() { new Moves.Surf() },
		[45] = new List<Move>() { new Moves.Muddywater() },
		[50] = new List<Move>() { new Moves.Meanlook() },
		[55] = new List<Move>() { new Moves.Naturesmadness() },
		[60] = new List<Move>() { new Moves.Moonblast() },
		[65] = new List<Move>() { new Moves.Hydropump() },
		[70] = new List<Move>() { new Moves.Soak() },
		[75] = new List<Move>() { new Moves.Mistyterrain() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Blizzard(), new Moves.Brine(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Mistyterrain(), new Moves.Muddywater(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Surf(), new Moves.Taunt(), new Moves.Trick(), new Moves.Waterfall(), new Moves.Whirlpool(), new Moves.Wonderroom() };
	public override int Weight => 212;
	public override int ExpYield => 285;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}