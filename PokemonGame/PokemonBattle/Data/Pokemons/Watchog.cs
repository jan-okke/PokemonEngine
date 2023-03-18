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
		public override List<Ability> AvailableAbilities => new() {new Illuminate(), new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(60, 85, 69, 77, 60, 69);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Confuseray() },
			[1] = new List<Move>() { new Confuseray(), new Rototiller(), new Tackle(), new Leer(), new Bite(), new Lowkick() },
			[3] = new List<Move>() { new Leer() },
			[6] = new List<Move>() { new Bite() },
			[8] = new List<Move>() { new Bide() },
			[11] = new List<Move>() { new Detect() },
			[13] = new List<Move>() { new Sandattack() },
			[16] = new List<Move>() { new Crunch() },
			[18] = new List<Move>() { new Hypnosis() },
			[22] = new List<Move>() { new Superfang() },
			[25] = new List<Move>() { new Afteryou() },
			[29] = new List<Move>() { new Focusenergy() },
			[32] = new List<Move>() { new Psychup() },
			[36] = new List<Move>() { new Hyperfang() },
			[39] = new List<Move>() { new Nastyplot() },
			[43] = new List<Move>() { new Meanlook() },
			[46] = new List<Move>() { new Batonpass() },
			[50] = new List<Move>() { new Slam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Aquatail(), new Attract(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Dreameater(), new Endeavor(), new Facade(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irontail(), new Knockoff(), new Laserfocus(), new Lastresort(), new Lightscreen(), new Lowkick(), new Poweruppunch(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Seedbomb(), new Shadowball(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Swordsdance(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Toxic(), new Workup(), new Zenheadbutt() };
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