using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tapubulu : Pokemon
{
	public override string Name => "Tapu Bulu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Grassysurge() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(70, 130, 115, 85, 95, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leafage(), new Moves.Rocksmash() },
		[5] = new List<Move>() { new Moves.Withdraw() },
		[10] = new List<Move>() { new Moves.Disable() },
		[15] = new List<Move>() { new Moves.Leechseed() },
		[20] = new List<Move>() { new Moves.Megadrain() },
		[25] = new List<Move>() { new Moves.Whirlwind() },
		[30] = new List<Move>() { new Moves.Hornattack() },
		[35] = new List<Move>() { new Moves.Scaryface() },
		[40] = new List<Move>() { new Moves.Hornleech() },
		[45] = new List<Move>() { new Moves.Zenheadbutt() },
		[50] = new List<Move>() { new Moves.Meanlook() },
		[55] = new List<Move>() { new Moves.Naturesmadness() },
		[60] = new List<Move>() { new Moves.Woodhammer() },
		[65] = new List<Move>() { new Moves.Megahorn() },
		[70] = new List<Move>() { new Moves.Skullbash() },
		[75] = new List<Move>() { new Moves.Grassyterrain() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulletseed(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Darkestlariat(), new Moves.Dazzlinggleam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyterrain(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Megahorn(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 455;
	public override int ExpYield => 285;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}