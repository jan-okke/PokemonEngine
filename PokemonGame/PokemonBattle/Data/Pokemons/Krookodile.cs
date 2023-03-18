using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Krookodile : Pokemon
	{
		public override string Name => "Krookodile";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Moxie() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Angerpoint() };
		public override Stats BaseStats => new Stats(95, 117, 80, 65, 70, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powertrip(), new Leer(), new Sandattack(), new Honeclaws() },
			[9] = new List<Move>() { new Sandtomb() },
			[12] = new List<Move>() { new Scaryface() },
			[15] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Torment() },
			[21] = new List<Move>() { new Dig() },
			[24] = new List<Move>() { new Swagger() },
			[27] = new List<Move>() { new Crunch() },
			[32] = new List<Move>() { new Sandstorm() },
			[35] = new List<Move>() { new Foulplay() },
			[44] = new List<Move>() { new Earthquake() },
			[51] = new List<Move>() { new Thrash() },
			[58] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Beatup(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Closecombat(), new Crunch(), new Darkestlariat(), new Darkpulse(), new Dig(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firefang(), new Fling(), new Focusblast(), new Focusenergy(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irontail(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Outrage(), new Payback(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaleshot(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Taunt(), new Thief(), new Throatchop(), new Thunderfang(), new Uproar() };
		public override int Weight => 963;
		public override int ExpYield => 260;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}