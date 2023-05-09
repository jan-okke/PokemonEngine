using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Slowbro : Pokemon
{
	public override string Name => "Slowbro";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Owntempo() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
	public override Stats BaseStats => new Stats(95, 75, 110, 100, 80, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Withdraw(), new Moves.Tackle(), new Moves.Curse(), new Moves.Growl(), new Moves.Watergun() },
		[9] = new List<Move>() { new Moves.Yawn() },
		[12] = new List<Move>() { new Moves.Confusion() },
		[15] = new List<Move>() { new Moves.Disable() },
		[18] = new List<Move>() { new Moves.Waterpulse() },
		[21] = new List<Move>() { new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Zenheadbutt() },
		[27] = new List<Move>() { new Moves.Amnesia() },
		[30] = new List<Move>() { new Moves.Surf() },
		[33] = new List<Move>() { new Moves.Slackoff() },
		[36] = new List<Move>() { new Moves.Psychic() },
		[41] = new List<Move>() { new Moves.Psychup() },
		[46] = new List<Move>() { new Moves.Raindance() },
		[51] = new List<Move>() { new Moves.Healpulse() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Nastyplot(), new Moves.Payday(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Recycle(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 785;
	public override int ExpYield => 172;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}