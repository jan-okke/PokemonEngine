using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tapulele : Pokemon
{
	public override string Name => "Tapu Lele";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Psychicsurge() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(70, 85, 75, 130, 115, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Confusion() },
		[5] = new List<Move>() { new Moves.Withdraw() },
		[10] = new List<Move>() { new Moves.Aromatherapy() },
		[15] = new List<Move>() { new Moves.Drainingkiss() },
		[20] = new List<Move>() { new Moves.Psybeam() },
		[25] = new List<Move>() { new Moves.Flatter() },
		[30] = new List<Move>() { new Moves.Aromaticmist() },
		[35] = new List<Move>() { new Moves.Sweetscent() },
		[40] = new List<Move>() { new Moves.Extrasensory() },
		[45] = new List<Move>() { new Moves.Psyshock() },
		[50] = new List<Move>() { new Moves.Meanlook() },
		[55] = new List<Move>() { new Moves.Naturesmadness() },
		[60] = new List<Move>() { new Moves.Moonblast() },
		[65] = new List<Move>() { new Moves.Tickle() },
		[70] = new List<Move>() { new Moves.Skillswap() },
		[75] = new List<Move>() { new Moves.Psychicterrain() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Playrough(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Wonderroom() };
	public override int Weight => 186;
	public override int ExpYield => 285;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}