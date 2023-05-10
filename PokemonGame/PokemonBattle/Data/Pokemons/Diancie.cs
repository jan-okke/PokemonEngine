using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Diancie : Pokemon
{
	public override string Name => "Diancie";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody() };
	public override Stats BaseStats => new Stats(50, 100, 150, 100, 150, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
		[7] = new List<Move>() { new Moves.Guardsplit() },
		[14] = new List<Move>() { new Moves.Smackdown() },
		[21] = new List<Move>() { new Moves.Flail() },
		[28] = new List<Move>() { new Moves.Ancientpower() },
		[35] = new List<Move>() { new Moves.Rockpolish() },
		[42] = new List<Move>() { new Moves.Lightscreen() },
		[49] = new List<Move>() { new Moves.Rockslide() },
		[56] = new List<Move>() { new Moves.Skillswap() },
		[63] = new List<Move>() { new Moves.Powergem() },
		[70] = new List<Move>() { new Moves.Stealthrock() },
		[77] = new List<Move>() { new Moves.Moonblast() },
		[84] = new List<Move>() { new Moves.Stoneedge() },
		[91] = new List<Move>() { new Moves.Diamondstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Batonpass(), new Moves.Bodypress(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Earthpower(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Metronome(), new Moves.Mistyexplosion(), new Moves.Mysticalfire(), new Moves.Playrough(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Terrainpulse(), new Moves.Trickroom(), new Moves.Wonderroom() };
	public override int Weight => 88;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}