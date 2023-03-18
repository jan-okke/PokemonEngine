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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Moxie() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Angerpoint() };
		public override Stats BaseStats => new Stats(95, 117, 80, 65, 70, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Powertrip(), new Moves.Leer(), new Moves.Sandattack(), new Moves.Honeclaws() },
			[9] = new List<Move>() { new Moves.Sandtomb() },
			[12] = new List<Move>() { new Moves.Scaryface() },
			[15] = new List<Move>() { new Moves.Bite() },
			[18] = new List<Move>() { new Moves.Torment() },
			[21] = new List<Move>() { new Moves.Dig() },
			[24] = new List<Move>() { new Moves.Swagger() },
			[27] = new List<Move>() { new Moves.Crunch() },
			[32] = new List<Move>() { new Moves.Sandstorm() },
			[35] = new List<Move>() { new Moves.Foulplay() },
			[44] = new List<Move>() { new Moves.Earthquake() },
			[51] = new List<Move>() { new Moves.Thrash() },
			[58] = new List<Move>() { new Moves.Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Darkestlariat(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderfang(), new Moves.Uproar() };
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