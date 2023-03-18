using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Watchog : Pokemon
	{
		public override string Name => "Watchog";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Illuminate(), new Abilities.Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
		public override Stats BaseStats => new Stats(60, 85, 69, 60, 69, 77);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Confuseray() },
			[1] = new List<Move>() { new Moves.Confuseray(), new Moves.Rototiller(), new Moves.Tackle(), new Moves.Leer(), new Moves.Bite(), new Moves.Lowkick() },
			[3] = new List<Move>() { new Moves.Leer() },
			[6] = new List<Move>() { new Moves.Bite() },
			[8] = new List<Move>() { new Moves.Bide() },
			[11] = new List<Move>() { new Moves.Detect() },
			[13] = new List<Move>() { new Moves.Sandattack() },
			[16] = new List<Move>() { new Moves.Crunch() },
			[18] = new List<Move>() { new Moves.Hypnosis() },
			[22] = new List<Move>() { new Moves.Superfang() },
			[25] = new List<Move>() { new Moves.Afteryou() },
			[29] = new List<Move>() { new Moves.Focusenergy() },
			[32] = new List<Move>() { new Moves.Psychup() },
			[36] = new List<Move>() { new Moves.Hyperfang() },
			[39] = new List<Move>() { new Moves.Nastyplot() },
			[43] = new List<Move>() { new Moves.Meanlook() },
			[46] = new List<Move>() { new Moves.Batonpass() },
			[50] = new List<Move>() { new Moves.Slam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Laserfocus(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override int Weight => 270;
		public override int ExpYield => 147;
		public override int CatchRate => 255;
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