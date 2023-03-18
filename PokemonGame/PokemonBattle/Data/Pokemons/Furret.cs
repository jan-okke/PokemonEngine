using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Furret : Pokemon
	{
		public override string Name => "Furret";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Frisk() };
		public override Stats BaseStats => new Stats(85, 76, 64, 45, 55, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Agility() },
			[1] = new List<Move>() { new Agility(), new Coil(), new Scratch(), new Defensecurl(), new Quickattack() },
			[4] = new List<Move>() { new Defensecurl() },
			[7] = new List<Move>() { new Quickattack() },
			[13] = new List<Move>() { new Furyswipes() },
			[17] = new List<Move>() { new Helpinghand() },
			[21] = new List<Move>() { new Followme() },
			[28] = new List<Move>() { new Slam() },
			[32] = new List<Move>() { new Rest() },
			[36] = new List<Move>() { new Suckerpunch() },
			[42] = new List<Move>() { new Amnesia() },
			[46] = new List<Move>() { new Batonpass() },
			[50] = new List<Move>() { new Reversal() },
			[56] = new List<Move>() { new Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Brickbreak(), new Brutalswing(), new Chargebeam(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Irontail(), new Knockoff(), new Lastresort(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Surf(), new Swagger(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Trick(), new Uproar(), new Uturn(), new Waterpulse(), new Workup() };
		public override int Weight => 325;
		public override int ExpYield => 145;
		public override int CatchRate => 90;
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