using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zangoose : Pokemon
	{
		public override string Name => "Zangoose";
		public override List<Ability> AvailableAbilities => new() {new Immunity() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Toxicboost() };
		public override Stats BaseStats => new Stats(73, 115, 60, 90, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[5] = new List<Move>() { new Quickattack() },
			[8] = new List<Move>() { new Furycutter() },
			[12] = new List<Move>() { new Honeclaws() },
			[15] = new List<Move>() { new Aerialace() },
			[19] = new List<Move>() { new Slash() },
			[22] = new List<Move>() { new Revenge() },
			[26] = new List<Move>() { new Crushclaw() },
			[29] = new List<Move>() { new Falseswipe() },
			[33] = new List<Move>() { new Facade() },
			[36] = new List<Move>() { new Detect() },
			[40] = new List<Move>() { new Xscissor() },
			[43] = new List<Move>() { new Taunt() },
			[47] = new List<Move>() { new Swordsdance() },
			[50] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Brickbreak(), new Confide(), new Dig(), new Doubleteam(), new Embargo(), new Endeavor(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigadrain(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Knockoff(), new Lastresort(), new Lowkick(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Waterpulse(), new Workup(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Bellydrum(), new Counter(), new Curse(), new Disable(), new Doublehit(), new Doublekick(), new Feint(), new Finalgambit(), new Flail(), new Furyswipes(), new Metalclaw(), new Nightslash(), new Quickguard() };
		public override int Weight => 403;
		public override int ExpYield => 160;
		public override int CatchRate => 90;
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