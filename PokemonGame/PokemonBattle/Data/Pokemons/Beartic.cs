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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Snowcloak(), new Abilities.Slushrush() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
		public override Stats BaseStats => new Stats(95, 130, 80, 70, 80, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Iciclecrash() },
			[1] = new List<Move>() { new Moves.Iciclecrash(), new Moves.Aquajet(), new Moves.Charm(), new Moves.Powdersnow(), new Moves.Growl(), new Moves.Endure(), new Moves.Furyswipes() },
			[9] = new List<Move>() { new Moves.Icywind() },
			[12] = new List<Move>() { new Moves.Playnice() },
			[15] = new List<Move>() { new Moves.Brine() },
			[18] = new List<Move>() { new Moves.Frostbreath() },
			[21] = new List<Move>() { new Moves.Slash() },
			[24] = new List<Move>() { new Moves.Flail() },
			[27] = new List<Move>() { new Moves.Swagger() },
			[30] = new List<Move>() { new Moves.Hail() },
			[33] = new List<Move>() { new Moves.Thrash() },
			[36] = new List<Move>() { new Moves.Rest() },
			[41] = new List<Move>() { new Moves.Blizzard() },
			[46] = new List<Move>() { new Moves.Sheercold() },
			[51] = new List<Move>() { new Moves.Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Dig(), new Moves.Dive(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop() };
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