using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Beartic : Pokemon
	{
		public override string Name => "Beartic";
		public override List<Ability> AvailableAbilities => new() {new Snowcloak(), new Slushrush() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(95, 130, 80, 70, 80, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Iciclecrash() },
			[1] = new List<Move>() { new Iciclecrash(), new Aquajet(), new Charm(), new Powdersnow(), new Growl(), new Endure(), new Furyswipes() },
			[9] = new List<Move>() { new Icywind() },
			[12] = new List<Move>() { new Playnice() },
			[15] = new List<Move>() { new Brine() },
			[18] = new List<Move>() { new Frostbreath() },
			[21] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Flail() },
			[27] = new List<Move>() { new Swagger() },
			[30] = new List<Move>() { new Hail() },
			[33] = new List<Move>() { new Thrash() },
			[36] = new List<Move>() { new Rest() },
			[41] = new List<Move>() { new Blizzard() },
			[46] = new List<Move>() { new Sheercold() },
			[51] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Brickbreak(), new Brine(), new Bulkup(), new Bulldoze(), new Charm(), new Dig(), new Dive(), new Encore(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Hail(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icepunch(), new Iciclespear(), new Icywind(), new Liquidation(), new Lowkick(), new Megakick(), new Megapunch(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Superpower(), new Surf(), new Swordsdance(), new Taunt(), new Throatchop() };
		public override int Weight => 2600;
		public override int ExpYield => 177;
		public override int CatchRate => 60;
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