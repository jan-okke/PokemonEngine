using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golisopod : Pokemon
	{
		public override string Name => "Golisopod";
		public override List<Ability> AvailableAbilities => new() {new Emergencyexit() };
		public override Stats BaseStats => new Stats(75, 125, 140, 40, 60, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Firstimpression() },
			[1] = new List<Move>() { new Firstimpression(), new Strugglebug(), new Sandattack(), new Defensecurl(), new Spite() },
			[4] = new List<Move>() { new Rocksmash() },
			[8] = new List<Move>() { new Furycutter() },
			[12] = new List<Move>() { new Mudshot() },
			[16] = new List<Move>() { new Bugbite() },
			[20] = new List<Move>() { new Irondefense() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Slash() },
			[32] = new List<Move>() { new Razorshell() },
			[36] = new List<Move>() { new Pinmissile() },
			[40] = new List<Move>() { new Swordsdance() },
			[44] = new List<Move>() { new Liquidation() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Brickbreak(), new Bugbuzz(), new Bulkup(), new Closecombat(), new Darkpulse(), new Dive(), new Drillrun(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Ironhead(), new Leechlife(), new Liquidation(), new Muddywater(), new Mudshot(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Scald(), new Screech(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snarl(), new Snore(), new Spikes(), new Substitute(), new Surf(), new Swift(), new Swordsdance(), new Taunt(), new Throatchop(), new Venoshock(), new Waterfall(), new Xscissor() };
		public override int Weight => 1080;
		public override int ExpYield => 186;
		public override int CatchRate => 45;
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
}