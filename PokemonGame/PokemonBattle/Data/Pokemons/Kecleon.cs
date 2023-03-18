using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kecleon : Pokemon
	{
		public override string Name => "Kecleon";
		public override List<Ability> AvailableAbilities => new() {new Colorchange() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Protean() };
		public override Stats BaseStats => new Stats(60, 90, 70, 60, 120, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thief(), new Tailwhip(), new Astonish(), new Lick(), new Scratch() },
			[4] = new List<Move>() { new Bind() },
			[7] = new List<Move>() { new Shadowsneak() },
			[10] = new List<Move>() { new Feint() },
			[13] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Disable() },
			[18] = new List<Move>() { new Psybeam() },
			[21] = new List<Move>() { new Ancientpower() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Detect() },
			[33] = new List<Move>() { new Shadowclaw() },
			[38] = new List<Move>() { new Screech() },
			[42] = new List<Move>() { new Substitute() },
			[46] = new List<Move>() { new Suckerpunch() },
			[50] = new List<Move>() { new Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Afteryou(), new Aquatail(), new Attract(), new Bind(), new Blizzard(), new Brickbreak(), new Chargebeam(), new Confide(), new Cut(), new Dig(), new Doubleteam(), new Drainpunch(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Focuspunch(), new Foulplay(), new Frustration(), new Grassknot(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Knockoff(), new Lastresort(), new Lowkick(), new Magiccoat(), new Nastyplot(), new Poweruppunch(), new Protect(), new Psychup(), new Raindance(), new Recycle(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Solarbeam(), new Stealthrock(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Trick(), new Trickroom(), new Waterpulse(), new Wonderroom(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Disable(), new Fakeout(), new Foulplay(), new Magiccoat(), new Poweruppunch(), new Recover(), new Trick() };
		public override int Weight => 220;
		public override int ExpYield => 154;
		public override int CatchRate => 200;
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