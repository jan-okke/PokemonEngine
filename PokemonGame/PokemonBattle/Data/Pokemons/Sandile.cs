using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sandile : Pokemon
	{
		public override string Name => "Sandile";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Moxie() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Angerpoint() };
		public override Stats BaseStats => new Stats(50, 72, 35, 35, 35, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powertrip(), new Leer() },
			[3] = new List<Move>() { new Sandattack() },
			[6] = new List<Move>() { new Honeclaws() },
			[9] = new List<Move>() { new Sandtomb() },
			[12] = new List<Move>() { new Scaryface() },
			[15] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Torment() },
			[21] = new List<Move>() { new Dig() },
			[24] = new List<Move>() { new Swagger() },
			[27] = new List<Move>() { new Crunch() },
			[30] = new List<Move>() { new Sandstorm() },
			[33] = new List<Move>() { new Foulplay() },
			[36] = new List<Move>() { new Earthquake() },
			[39] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Beatup(), new Bulldoze(), new Crunch(), new Darkpulse(), new Dig(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firefang(), new Focusenergy(), new Foulplay(), new Hiddenpower(), new Irontail(), new Lashout(), new Payback(), new Protect(), new Rest(), new Retaliate(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Scorchingsands(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Taunt(), new Thief(), new Thunderfang(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Aquatail(), new Counter(), new Doubleedge(), new Spite() };
		public override int Weight => 152;
		public override int ExpYield => 58;
		public override int CatchRate => 180;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}