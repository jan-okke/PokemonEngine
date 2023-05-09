using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mrrime : Pokemon
{
	public override string Name => "Mr. Rime";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Tangledfeet(), new Abilities.Screencleaner() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Icebody() };
	public override Stats BaseStats => new Stats(80, 85, 75, 110, 100, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Faketears(), new Moves.Slackoff(), new Moves.Afteryou(), new Moves.Block(), new Moves.Copycat(), new Moves.Encore(), new Moves.Roleplay(), new Moves.Protect(), new Moves.Recycle(), new Moves.Mimic(), new Moves.Lightscreen(), new Moves.Reflect(), new Moves.Safeguard(), new Moves.Dazzlinggleam(), new Moves.Mistyterrain(), new Moves.Pound(), new Moves.Rapidspin(), new Moves.Batonpass(), new Moves.Iceshard() },
		[12] = new List<Move>() { new Moves.Confusion() },
		[16] = new List<Move>() { new Moves.Allyswitch() },
		[20] = new List<Move>() { new Moves.Icywind() },
		[24] = new List<Move>() { new Moves.Doublekick() },
		[28] = new List<Move>() { new Moves.Psybeam() },
		[32] = new List<Move>() { new Moves.Hypnosis() },
		[36] = new List<Move>() { new Moves.Mirrorcoat() },
		[40] = new List<Move>() { new Moves.Suckerpunch() },
		[44] = new List<Move>() { new Moves.Freezedry() },
		[48] = new List<Move>() { new Moves.Psychic() },
		[52] = new List<Move>() { new Moves.Teeterdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Mistyterrain(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Confuseray(), new Moves.Fakeout(), new Moves.Hypnosis(), new Moves.Powersplit(), new Moves.Tickle() };
	public override int Weight => 582;
	public override int ExpYield => 182;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}