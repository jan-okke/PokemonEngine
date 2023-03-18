using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ambipom : Pokemon
	{
		public override string Name => "Ambipom";
		public override List<Ability> AvailableAbilities => new() {new Technician(), new Pickup() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Skilllink() };
		public override Stats BaseStats => new Stats(75, 100, 66, 115, 60, 66);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dualchop(), new Scratch(), new Tailwhip(), new Sandattack(), new Astonish() },
			[4] = new List<Move>() { new Sandattack() },
			[8] = new List<Move>() { new Astonish() },
			[11] = new List<Move>() { new Batonpass() },
			[15] = new List<Move>() { new Tickle() },
			[18] = new List<Move>() { new Furyswipes() },
			[22] = new List<Move>() { new Swift() },
			[25] = new List<Move>() { new Screech() },
			[29] = new List<Move>() { new Agility() },
			[32] = new List<Move>() { new Doublehit() },
			[36] = new List<Move>() { new Fling() },
			[39] = new List<Move>() { new Nastyplot() },
			[43] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bounce(), new Brickbreak(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focuspunch(), new Foulplay(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irontail(), new Knockoff(), new Laserfocus(), new Lastresort(), new Lowkick(), new Lowsweep(), new Nastyplot(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Roleplay(), new Round(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snatch(), new Snore(), new Solarbeam(), new Spite(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Uturn(), new Waterpulse(), new Workup() };
		public override int Weight => 203;
		public override int ExpYield => 169;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}