using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kirlia : Pokemon
{
	public override string Name => "Kirlia";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Synchronize(), new Abilities.Trace() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(38, 35, 35, 65, 55, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Growl(), new Moves.Disarmingvoice(), new Moves.Doubleteam(), new Moves.Confusion() },
		[9] = new List<Move>() { new Moves.Hypnosis() },
		[12] = new List<Move>() { new Moves.Drainingkiss() },
		[15] = new List<Move>() { new Moves.Teleport() },
		[18] = new List<Move>() { new Moves.Psybeam() },
		[23] = new List<Move>() { new Moves.Lifedew() },
		[28] = new List<Move>() { new Moves.Charm() },
		[33] = new List<Move>() { new Moves.Calmmind() },
		[38] = new List<Move>() { new Moves.Psychic() },
		[43] = new List<Move>() { new Moves.Healpulse() },
		[48] = new List<Move>() { new Moves.Dreameater() },
		[53] = new List<Move>() { new Moves.Futuresight() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Futuresight(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mistyterrain(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Tripleaxel(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 202;
	public override int ExpYield => 97;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}