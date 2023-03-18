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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Frisk() };
		public override Stats BaseStats => new Stats(35, 46, 34, 35, 45, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Growl() },
			[4] = new List<Move>() { new Moves.Defensecurl() },
			[7] = new List<Move>() { new Moves.Quickattack() },
			[13] = new List<Move>() { new Moves.Furyswipes() },
			[16] = new List<Move>() { new Moves.Helpinghand() },
			[19] = new List<Move>() { new Moves.Followme() },
			[25] = new List<Move>() { new Moves.Slam() },
			[28] = new List<Move>() { new Moves.Rest() },
			[31] = new List<Move>() { new Moves.Suckerpunch() },
			[36] = new List<Move>() { new Moves.Amnesia() },
			[39] = new List<Move>() { new Moves.Batonpass() },
			[42] = new List<Move>() { new Moves.Reversal() },
			[47] = new List<Move>() { new Moves.Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Trick(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Babydolleyes(), new Moves.Charm(), new Moves.Covet(), new Moves.Doubleedge(), new Moves.Focusenergy(), new Moves.Lastresort(), new Moves.Reversal(), new Moves.Slash(), new Moves.Trick() };
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