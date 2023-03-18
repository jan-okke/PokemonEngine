using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kabutops : Pokemon
	{
		public override string Name => "Kabutops";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Battlearmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(60, 115, 105, 80, 65, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slash() },
			[1] = new List<Move>() { new Slash(), new Nightslash(), new Feint(), new Absorb(), new Harden(), new Scratch(), new Sandattack() },
			[15] = new List<Move>() { new Aquajet() },
			[20] = new List<Move>() { new Leer() },
			[25] = new List<Move>() { new Mudshot() },
			[30] = new List<Move>() { new Ancientpower() },
			[35] = new List<Move>() { new Brine() },
			[43] = new List<Move>() { new Protect() },
			[49] = new List<Move>() { new Leechlife() },
			[56] = new List<Move>() { new Liquidation() },
			[63] = new List<Move>() { new Metalsound() },
			[70] = new List<Move>() { new Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brine(), new Crosspoison(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Flipturn(), new Gigadrain(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Leechlife(), new Liquidation(), new Lowkick(), new Megakick(), new Meteorbeam(), new Mudshot(), new Protect(), new Psychocut(), new Raindance(), new Razorshell(), new Rest(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Screech(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Xscissor() };
		public override int Weight => 405;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}