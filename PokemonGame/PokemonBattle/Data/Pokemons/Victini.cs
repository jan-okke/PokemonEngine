using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Victini : Pokemon
{
	public override string Name => "Victini";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Victorystar() };
	public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Vcreate(), new Moves.Quickattack(), new Moves.Flamecharge(), new Moves.Confusion(), new Moves.Focusenergy() },
		[7] = new List<Move>() { new Moves.Workup() },
		[14] = new List<Move>() { new Moves.Incinerate() },
		[21] = new List<Move>() { new Moves.Storedpower() },
		[28] = new List<Move>() { new Moves.Headbutt() },
		[35] = new List<Move>() { new Moves.Endure() },
		[42] = new List<Move>() { new Moves.Zenheadbutt() },
		[49] = new List<Move>() { new Moves.Inferno() },
		[56] = new List<Move>() { new Moves.Reversal() },
		[63] = new List<Move>() { new Moves.Searingshot() },
		[70] = new List<Move>() { new Moves.Doubleedge() },
		[77] = new List<Move>() { new Moves.Flareblitz() },
		[84] = new List<Move>() { new Moves.Overheat() },
		[91] = new List<Move>() { new Moves.Finalgambit() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Batonpass(), new Moves.Blazekick(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Dazzlinggleam(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 40;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}