using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Misdreavus : Pokemon
	{
		public override string Name => "Misdreavus";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(60, 60, 60, 85, 85, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Confusion() },
			[5] = new List<Move>() { new Spite() },
			[10] = new List<Move>() { new Astonish() },
			[14] = new List<Move>() { new Confuseray() },
			[19] = new List<Move>() { new Meanlook() },
			[23] = new List<Move>() { new Hex() },
			[28] = new List<Move>() { new Psybeam() },
			[32] = new List<Move>() { new Painsplit() },
			[37] = new List<Move>() { new Payback() },
			[41] = new List<Move>() { new Shadowball() },
			[46] = new List<Move>() { new Perishsong() },
			[50] = new List<Move>() { new Grudge() },
			[55] = new List<Move>() { new Powergem() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Allyswitch(), new Attract(), new Calmmind(), new Chargebeam(), new Confide(), new Darkpulse(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Embargo(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Healbell(), new Hiddenpower(), new Hypervoice(), new Icywind(), new Magiccoat(), new Magicroom(), new Nastyplot(), new Painsplit(), new Payback(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Spite(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Uproar(), new Willowisp(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Destinybond(), new Imprison(), new Memento(), new Screech(), new Shadowsneak(), new Spite(), new Suckerpunch(), new Wonderroom() };
		public override int Weight => 10;
		public override int ExpYield => 87;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}