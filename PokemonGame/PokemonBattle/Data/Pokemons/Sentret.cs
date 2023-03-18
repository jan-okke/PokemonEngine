using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sentret : Pokemon
	{
		public override string Name => "Sentret";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Frisk() };
		public override Stats BaseStats => new Stats(35, 46, 34, 35, 45, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl() },
			[4] = new List<Move>() { new Defensecurl() },
			[7] = new List<Move>() { new Quickattack() },
			[13] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Helpinghand() },
			[19] = new List<Move>() { new Followme() },
			[25] = new List<Move>() { new Slam() },
			[28] = new List<Move>() { new Rest() },
			[31] = new List<Move>() { new Suckerpunch() },
			[36] = new List<Move>() { new Amnesia() },
			[39] = new List<Move>() { new Batonpass() },
			[42] = new List<Move>() { new Reversal() },
			[47] = new List<Move>() { new Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Brickbreak(), new Brutalswing(), new Chargebeam(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Firepunch(), new Flamethrower(), new Fling(), new Focuspunch(), new Frustration(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icepunch(), new Irontail(), new Knockoff(), new Lastresort(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Superfang(), new Surf(), new Swagger(), new Thief(), new Thunderbolt(), new Thunderpunch(), new Trick(), new Uproar(), new Uturn(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Babydolleyes(), new Charm(), new Covet(), new Doubleedge(), new Focusenergy(), new Lastresort(), new Reversal(), new Slash(), new Trick() };
		public override int Weight => 60;
		public override int ExpYield => 43;
		public override int CatchRate => 255;
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